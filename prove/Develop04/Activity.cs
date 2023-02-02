
public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityLength;
    protected DateTime _futureTime;
    protected DateTime _currentTime;
    

    public Activity()
    {
        _activityName = "";
        _activityDescription = "";
    }
    
    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
    }

    public void SetActivityLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityLength = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void EndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Welldone!");
        Spinner(3);
        Console.WriteLine($"You have complete another {_activityLength} seconds of the {_activityName} Activity");
        Spinner(5);
    }

    public void SetTimer()
    {
        DateTime startTime = DateTime.Now;
        _futureTime = startTime.AddSeconds(_activityLength);
    }

    public void UpdateTimer()
    {
        _currentTime = DateTime.Now;
    }

    public void Spinner(int spinTime)
    {
        Console.CursorVisible = false;
        for (int counter = spinTime; counter > 0; counter--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("\\");            
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("|");        
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            Console.Write("/");        
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.Write("\b \b\n");
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        Spinner(4);
        Console.WriteLine("\n");
    }
}