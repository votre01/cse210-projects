
public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityLength;
    

    public Activity()
    {
        _activityName = "";
        _activityDescription = "";
        _activityLength = 10;
    }

    public string StartingMessage()
    {
        return $"Welcome to the {_activityName} Activity";
    }

    public string EndingMessage()
    {
        return $"You have complete another {_activityLength} of the {_activityName}";
    }

    public void RunTimer()
    {

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(30);

        

        DateTime currrentTime = DateTime.Now;
        while (currrentTime < futureTime)
        {
            Console.WriteLine("Type something");
            Console.ReadLine();
            currrentTime = DateTime.Now;
        }
        
        Console.WriteLine("Done!");

        /*for (int s = _activityLength; s > 0; s-- )
        {
            Thread.Sleep(1000);
            Console.Write(s);
        }*/
    }

    public void Spinner()
    {

    }
}