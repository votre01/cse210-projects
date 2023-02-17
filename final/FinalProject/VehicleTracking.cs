public class VehicleTracking
{
    private bool _trackingClearance = false;
    private List<string> _locations = new List<string>();

    public VehicleTracking()
    {
        LoadLocations();
    }

    public void TrackVehicle()
    {        
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _locations.Count);
        Console.WriteLine();
        Console.WriteLine("Tracking was successful!");
        Console.WriteLine($"Tracking data shows ({_locations[randomIndex]}) as the last seen location of the vehicle.");
        Console.WriteLine();
    }

    public void ReportMissingVehicle(List<Vehicle> vehicles)
    {
        Console.Clear();
        Console.WriteLine("===== Missing vehicle report and tracking clearance =====\n");      
        Console.Write("Enter missing vehicle registration number: "); 
        string registration = Console.ReadLine();
        Console.WriteLine();

        int exists = 0;
        foreach (Vehicle vehicle in vehicles)
        {
            if (registration == vehicle.GetRegistrationNumber())
                exists++;
        }

        if (exists > 0)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (registration == vehicle.GetRegistrationNumber())
                {
                    _trackingClearance = true;
                    Console.WriteLine($"You have reported {vehicle.GetVehicleName()} {vehicle.GetVehicleModel()} - {vehicle.GetRegistrationNumber()} as missing. This vehicle has been cleared for tracking");
                    break;
                }
            }            
        }
        else
        {
            _trackingClearance = false;
            Console.WriteLine("Vehicle does not exist. Please see catalogue for correct registartion number.");
        }
        Console.WriteLine();
    } 

    private void LoadLocations()
    {
        string filename = "locations.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split();
            _locations.Add(line);
        }
    } 

    public bool IsCleared()
    {
        return _trackingClearance;
    }  
}