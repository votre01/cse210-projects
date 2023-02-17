using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;            
        MainMenu(running);
    }

    static void MainMenu(bool status)
    {
        VehicleProcessing vp = new VehicleProcessing();
        VehicleTracking track = new VehicleTracking();

        while (status)
        {
            Console.WriteLine($"Menu Options:");
            Console.WriteLine("\n\t1. Process Outgoing\n\t2. Save and Complete Entries\n\t3. Process Incoming\n\t4. View Catalogue\n\t5. Add New Vehicle\n\t6. Vehicle Tracking\n\t7. Quit\n");
            Console.Write("Select a choice from menu: ");

            int option = int.Parse(Console.ReadLine());            
            switch(option)
            {
                case 1:
                    vp.ProcessOutgoing();
                    break;
                case 2:
                    vp.SaveOutgoingProcess();
                    break;
                case 3:
                    vp.ProcessIncoming();
                    break;
                case 4:
                    vp.ViewCatalogue();
                    break;
                case 5:
                    vp.AddNewVehicle();
                    break;
                case 6:
                    vp.Tracking();
                    break;
                case 7:
                    status = false;
                    break;                                    
            }
        }
    }
}