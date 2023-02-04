public class EternalGoal : Goal
{
    int _goalCount;  

    public EternalGoal()
    {
        _goalCount = 0;
    }  
    public override void RecordEvent()
    {
        AddPoints();
        _goalCount++;                
    }

    public override void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            outputFile.WriteLine($"EternalGoal>{GetGoalName()}>{GetGoalDescription()}>{IsComplete()}>{GetAssociatedPoints()}");
        }
    }
}