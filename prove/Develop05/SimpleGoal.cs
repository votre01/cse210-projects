public class SimpleGoal : Goal
{
    //private bool _goalComplete;

    public override void RecordEvent()
    {
        AddPoints();
        _complete = true;
    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            outputFile.WriteLine($"SimpleGoal>{GetGoalName()}>{GetGoalDescription()}>{IsComplete()}>{GetAssociatedPoints()}");
        }
    }
}