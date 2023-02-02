public class Breathing : Activity
{
    private string _breathInMessage;
    private string _breathOutMessage;

    public Breathing()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _breathInMessage = "Breath in...";
        _breathOutMessage = "Now breath out...";
    }

    public void Breath()
    {
        StartingMessage();
        SetActivityLength();
        SetTimer();

        GetReady();

        while (_currentTime < _futureTime)
        {
            Console.CursorVisible = false;
            Console.Write($"{_breathInMessage}");
            for (int counter = 4; counter >= 0; counter--)
            {                                   
                if (counter == 0) 
                {
                    Console.CursorLeft = _breathInMessage.Length;
                    Console.Write(" ");                
                }
                else
                {
                    Console.CursorLeft = _breathInMessage.Length;                
                    Console.Write(counter);
                    Thread.Sleep(1000);
                }          
            }         

            Console.WriteLine();

            Console.Write($"{_breathOutMessage}");
            for (int counter = 6; counter >= 0; counter--)
            {
                if (counter == 0) 
                {
                    Console.CursorLeft = _breathOutMessage.Length;
                    Console.Write(" ");                
                }
                else
                {                
                    Console.CursorLeft = _breathOutMessage.Length;
                    Console.Write("{0}", counter );
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine("\n");
            UpdateTimer();
        }

        EndingMessage();
    }
}