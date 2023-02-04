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
        _performedCount++;
        AddPoints();                
    }

    public override void AddPoints()
    {
        base.AddPoints();
        AddBonus();
    }

    public override bool IsComplete()
    {
        if (_performedCount >= _target)
        _complete = true;

        return _complete;
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

    public void SetPerformedCountExternal(string performed)
    {
        _performedCount = int.Parse(performed);
    }

    public void SetTargetExternal(string target)
    {
        _target = int.Parse(target);
    }

    public void SetBonusExternal(string bonus)
    {
        _bonus = int.Parse(bonus);
    }

    public void AddBonus()
    {
        if (_performedCount == _target)
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

    public override void GoalListing()
    {
        if(IsComplete())
        {            
            Console.WriteLine($"[X] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {GetPerformedCount()}/{GetTarget()}");
        }
        else
        {
            Console.WriteLine($"[ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {GetPerformedCount()}/{GetTarget()}");
        }
    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            outputFile.WriteLine($"ChecklistGoal>{GetGoalName()}>{GetGoalDescription()}>{IsComplete()}>{GetAssociatedPoints()}>{GetPerformedCount()}>{GetTarget()}>{GetBonus()}");
        }
    }
}