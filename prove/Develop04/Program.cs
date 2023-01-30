using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing br = new Breathing();
        Reflecting rf = new Reflecting();
        Listing ls = new Listing();

        bool running = true;
        int choice = -1;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit");
            Console.Write("Select a choice from menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                br.Breath();
            }
            else if (choice == 2)
            {
                rf.Reflect();
            }
            else if (choice == 3)
            {
                ls.MakeList();
            }
            else if (choice == 4)
            {
                running = false;
            }
        }

        Console.WriteLine("Goodbye!");
    }      
}