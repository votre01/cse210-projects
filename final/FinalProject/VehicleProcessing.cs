public class VehicleProcessing
{
    private List<Vehicle> _processed = new List<Vehicle>();
    private List<Vehicle> _catalogue = new List<Vehicle>();
    private int _duration;
    private string _incomingVehicleCondition;
    private VehicleFileProcessing vfp = new VehicleFileProcessing();
    private NewVehicleEntry _addNewVehicle = new NewVehicleEntry();

    public VehicleProcessing()
    {
        LoadCatalogue();
    }

    private void LoadCatalogue()
    {        
        vfp.Load(_catalogue);
        //_catalogue.Sort();
    }

    public void ProcessOutgoing()
    {
        ViewCatalogue();
        Console.Write("Select vehicle to hire out: ");
        int selection = (int.Parse(Console.ReadLine())-1);

        Console.Write("How long in days is the hire: ");
        _duration = int.Parse(Console.ReadLine());

        _catalogue[selection].SetAvailability("false");
        //_catalogue[selection].Billing(_duration);
        _processed.Add(_catalogue[selection]);

        Console.WriteLine();
        Console.WriteLine($"{_catalogue[selection].GetVehicleName()} {_catalogue[selection].GetVehicleModel()} - {_catalogue[selection].GetRegistrationNumber()} has been queued in the order. Select \"Save and Complete entries\" to complete all orders.\n");
    }

    public void ProcessIncoming()
    {
        Console.Clear();
        Console.Write("Enter registration number of vehicle being returned: ");
        string registrationNumber = Console.ReadLine();
        Console.Write("What is the condition of the vehicle (Good/Damaged): ");
        string vehicleCondition = Console.ReadLine();

        Console.WriteLine();

        foreach (Vehicle vehicle in _catalogue)
        {
            if (vehicle.GetRegistrationNumber() == registrationNumber)
            {
                vehicle.SetAvailability("true");
                Console.Write($"{vehicle.GetVehicleName()} {vehicle.GetVehicleModel()} - {vehicle.GetRegistrationNumber()} has been returned in {vehicleCondition} condition. Select \"Save and Complete Entries\" to complete the entry");
                break;
            }            
        }
        Console.WriteLine("\n");
    }

    public void ViewCatalogue()
    {
        Console.Clear();
        int counter = 1;
        foreach (Vehicle vehicle in _catalogue)
        {
            Console.Write($"{counter}. {vehicle.GetVehicleCategory()}: {vehicle.GetVehicleName()} {vehicle.GetVehicleModel()} - {vehicle.GetRegistrationNumber()}: ");
                if (vehicle.Available())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Available");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unavailable");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                counter++;
        }
        Console.WriteLine();
    }

    public void SaveOutgoingProcess()
    {
        Console.Clear();
        Console.WriteLine("Your new order has been saved. You are hiring out:\n");
        foreach (Vehicle vehicle in _processed)
        {
            Console.WriteLine($"{vehicle.GetVehicleCategory()} vehicle: {vehicle.GetVehicleName()} {vehicle.GetVehicleModel()} for a total of ${vehicle.Billing(_duration)}");
        }
        WriteToFile("catalogue.csv");
        _processed.Clear();
        _catalogue.Clear();
        LoadCatalogue();

        Console.WriteLine();
    }

    private void WriteToFile(string filename)
    {

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Vehicle item in _catalogue)
            {
                outputFile.WriteLine(item.Save());
            }
        }
    }

    public void AddNewVehicle()
    {
        Console.Clear();
        _addNewVehicle.NewVehicle();
        _catalogue.Add(_addNewVehicle.GetVehicle());

        WriteToFile("catalogue.csv");
        _catalogue.Clear();
        LoadCatalogue();

        Console.WriteLine($"{_addNewVehicle.GetVehicle().GetVehicleCategory()} vehicle: {_addNewVehicle.GetVehicle().GetVehicleName()} {_addNewVehicle.GetVehicle().GetVehicleModel()} has been added to the catalogue.");
        Console.WriteLine();
    }

    public void Tracking()
    {
        VehicleTracking vt = new VehicleTracking();
        vt.ReportMissingVehicle(_catalogue);

        if (vt.IsCleared())
        {
            Console.Write("Track Vehicle\n1. Yes\n2.No\n>");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
                vt.TrackVehicle();
        }
    }
}