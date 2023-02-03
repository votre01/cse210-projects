public class SimpleGoal : Goal
{
    private bool _goalComplete;

    public override void RecordEvent()
    {
        AddPoints();
        _goalComplete = true;
    }

    public override bool IsComplete()
    {
        if (_goalComplete)
        {
            return true;
        }

        return false;
    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            outputFile.WriteLine($"SimpleGoal>{GetGoalName()}>{GetGoalDescription()}>{IsComplete()}");
        }
    }
}