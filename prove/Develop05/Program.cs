using System;

class Program
{
    static void Main(string[] args)
    {
        RecordProcessing rp = new RecordProcessing();
        bool running = true;

        Console.Clear();
        MainMenu(rp, running);    
    }

    static void MainMenu(RecordProcessing rp, bool status)
    {
        while (status)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {rp.GetTotalPoints()} points.");
            Console.WriteLine($"Menu Options:");
            Console.WriteLine("\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\n");
            Console.Write("Select a choice from menu: ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    rp.CreateNewGoal();
                    break;
                case 2:
                    rp.ListGoals();
                    break;
                case 3:
                    rp.Save();
                    break;
                case 4:
                    rp.Load();
                    break;
                case 5:
                    rp.Record();
                    break;
                case 6:
                    status = rp.Exit(option);
                    break;
            }
        }
    }
}