public class RecordProcessing
{
    private List<string> _goalsList = new List<string>();
    private List<Goal> _existingGoalsList = new List<Goal>();
    private List<Goal> _newGoalsList = new List<Goal>();
    private int _totalPoints;

    public RecordProcessing()
    {
        LoadTotalPoints();
    }

    public void CreateNewGoal()
    {
        Goal newGoal = null;
        Console.Clear();
        GoalsMenu();

        int goalChoice = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case 1:
                newGoal = new SimpleGoal();
                break;
            case 2:
                newGoal = new EternalGoal();
                break;
            case 3:
                newGoal = new ChecklistGoal();
                break;
            default:
                break;
        }

        newGoal.SetGoal();

        _newGoalsList.Add(newGoal); 
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void LoadTotalPoints()
    {
        string filename = "total-points.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        _totalPoints = int.Parse(lines[0]);
    }

    public void SaveTotalPoints()
    {
        string filename = "total-points.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
        }
    }

    public void Load()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("");
            _goalsList.Add(line);
        }

        LoadExistingGoals();
    }

    public void LoadExistingGoals()
    {
        //Goal newGoal = null;

        foreach (string goal in _goalsList)
        {
            string[] goalParts = goal.Split(">");

            if (goalParts[0] == "SimpleGoal")
            {
                SimpleGoal newGoal = new SimpleGoal();
                SetAdd(newGoal);
            }
            else if (goalParts[0] == "EternalGoal")
            {
                EternalGoal newGoal = new EternalGoal();
                SetAdd(newGoal);
            }
            else if (goalParts[0] == "ChecklistGoal")
            {
                ChecklistGoal newGoal = new ChecklistGoal();
                newGoal.SetPerformedCountExternal(goalParts[5]);
                newGoal.SetTargetExternal(goalParts[6]);
                newGoal.SetBonusExternal(goalParts[7]);
                SetAdd(newGoal);
            }

            void SetAdd(Goal goal)
            {
                goal.SetGoalNameExternal(goalParts[1]);
                goal.SetGoalDescriptionExternal(goalParts[2]);
                goal.SetCompleteExternal(goalParts[3]);
                goal.SetAssociatedPointsExternal(goalParts[4]);
                _existingGoalsList.Add(goal);                
            }            
        }
    }

    public void Save()
    {
        Console.Write("Name of file: ");
        string filename = Console.ReadLine();

        if (_existingGoalsList.Count > 0)
        {
            System.IO.File.WriteAllText(@filename, string.Empty);
            foreach (Goal goal in _existingGoalsList)
            {
                goal.SaveGoal(filename);
            }
        }

        foreach (Goal goal in _newGoalsList)
        {
            goal.SaveGoal(filename);
        }

        SaveTotalPoints();
    }

    private void GoalsMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. ChecklistGoal\n");
        Console.Write("Which type of goal would you like to create? ");
    }

    public void ListGoals()
    {
        Console.Clear();

        if(_existingGoalsList.Count > 0)        
        {
            Console.WriteLine("===< Current Goals >===");
            foreach(Goal goal in _existingGoalsList)
            {
                goal.GoalListing();
            }
        }

        if(_newGoalsList.Count > 0)
        {
            Console.WriteLine("===< New Goals >===");
            foreach(Goal goal in _newGoalsList)
            {
                goal.GoalListing();
            }
        }
    }

    public void Record()
    {
        Console.Clear();        
        RecordMenu();

        if (_newGoalsList.Count > 0)
        {
            Console.Write("Which goal did you accomplish? ");
            int option = int.Parse(Console.ReadLine());
            
            _newGoalsList[option - 1].RecordEvent();
            _totalPoints += _newGoalsList[option - 1].GetPoints();
            Console.WriteLine($"Congratulations! You have earned {_newGoalsList[option - 1].GetPoints()} points.");
        }

        if (_existingGoalsList.Count > 0)
        {
            Console.Write("Which goal did you accomplish? ");
            int option = int.Parse(Console.ReadLine());
            
            _existingGoalsList[option - 1].RecordEvent();
            _totalPoints += _existingGoalsList[option - 1].GetAssociatedPoints();
            Console.WriteLine($"Congratulations! You have earned {_existingGoalsList[option - 1].GetPoints()} points.");
        }

        void RecordMenu()
        {
            int count = 1;
            Console.WriteLine("The goals are: ");
            if (_existingGoalsList.Count > 0)
            {
                
                foreach(Goal goal in _existingGoalsList)
                {
                    Console.WriteLine($"{count}. {goal.GetGoalName()}");
                    count++;
                }
            }

            if (_newGoalsList.Count > 0)
            {
                foreach(Goal goal in _newGoalsList)
                {
                    Console.WriteLine($"{count}. {goal.GetGoalName()}");
                    count++;
                }
            }
        }        
    }

    public bool Exit(int choice)
    {
        if (_newGoalsList.Count > 0)
        {
            Console.Write("Don't forget to save! Press 0 to go back. Press 6 again to exit: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 0)
            {
                return true;
            }
            else if (choice == 6)
            {
                return false;
            }            
        }
        return false;
    }
}