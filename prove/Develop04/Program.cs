using System;

class Program
{
    static void Main(string[] args)
    {
        
        /*Console.Write("Generating Preview in ");
        for (int a = 10; a >= 0; a--)
        {
            //Console.CursorLeft = 22;
            Console.Write("{0} ", a );    // Add space to make sure to override previous contents
            System.Threading.Thread.Sleep(1000);
        }*/

        Activity activity = new Activity();
        activity.RunTimer();
    }
}