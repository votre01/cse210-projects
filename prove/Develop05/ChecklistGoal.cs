public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _performedCount;

    public ChecklistGoal()
    {
        _bonus = 0;
        _performedCount = 0;
        _target = 0;
    }

    public override void RecordEvent()
    {
        AddPoints();
        _performedCount++;        
    }

    public override bool IsComplete()
    {
        if (_performedCount >= _target)
        {
            return true;
        }

        return false;
    }

    public override void SetGoal()
    {
        base.SetGoal();
        SetTarget();
        SetBonus();        
    }

    private void SetTarget()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(Console.ReadLine());
    }

    private void SetBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public void AddBonus()
    {
        if (_performedCount >= _target)
        {
            _points += _bonus;
        }
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetPerformedCount()
    {
        return _performedCount;
    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            outputFile.WriteLine($"ChecklistGoal>{GetGoalName()}>{GetGoalDescription()}>{GetTarget()}>{GetPerformedCount()}>{GetBonus()}>{IsComplete()}");
        }
    }
}