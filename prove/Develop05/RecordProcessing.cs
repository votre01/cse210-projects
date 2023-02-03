public class RecordProcessing
{
    public List<string> _goalsList = new List<string>();
    public List<Goal> _existingGoalsList = new List<Goal>();
    public List<Goal> _newGoalsList = new List<Goal>();
    private int _totalPoints;

    public RecordProcessing()
    {
        // CalculateTotalPoints();
    }

    public void CreateNewGoal()
    {
        Goal newGoal = null;
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

    private void CalculateTotalPoints(int points)
    {
        _totalPoints += points;
    }

    public void Load()
    {
        Console.WriteLine("What is the filename: ");
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
        Goal newGoal = null;

        foreach (string goal in _goalsList)
        {
            string[] goalParts = goal.Split(">");

            if (goalParts[0] == "SimpleGoal")
            {
                newGoal = new SimpleGoal();
            }
            else if (goalParts[0] == "EternalGoal")
            {
                newGoal = new EternalGoal();
            }
            else if (goalParts[0] == "ChecklistGoal")
            {
                newGoal = new ChecklistGoal();
            }


            foreach (string part in goalParts)
            {                
                newGoal.SetGoalNameExternal(goalParts[1]);
                newGoal.SetGoalDescriptionExternal(goalParts[2]);
            }

            _existingGoalsList.Add(newGoal);
        }
    }

    public void Save()
    {
        Console.Write("Name of file: ");
        string filename = Console.ReadLine();

        foreach (Goal goal in _newGoalsList)
        {
            goal.SaveGoal(filename);
        }
        
    }

    private void GoalsMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. ChecklistGoal\n");
        Console.WriteLine("Which type of goal would you like to create");
    }
}