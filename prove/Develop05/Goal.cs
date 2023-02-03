public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    protected int _points;
    protected int _associatedPoints;

    public Goal()
    {
        _goalName = "";
        _goalDescription = "";
        _points = 0;
        _associatedPoints = 0;
    }

    public abstract void RecordEvent();

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual void SetGoal()
    {
        SetGoalName();
        SetGoalDescription();
        SetAssociatedPoints();
    } 

    public void AddPoints()
    {
        _points += _associatedPoints;
    }

    public void SetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public void SetGoalNameExternal(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
    }

    public void SetGoalDescriptionExternal(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void SetAssociatedPoints()
    {
        Console.Write("What is the amount points associated with this goal? ");
        _associatedPoints = int.Parse(Console.ReadLine());
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void SaveGoal(string filename);    
}