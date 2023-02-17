public class NewVehicleEntry
{
    Vehicle vehicle = null;    

    public void NewVehicle()
    {
        Console.WriteLine("Select new vehicle category: ");
        Console.WriteLine("\n\t1. Luxury Vehicle\n\t2. Business Vehicle\n\t3. Family Vehicle\n\t4. Sports Vehicle\n\t5. Truck Vehicle\n\t6. Economy Vehicle");

        int option = int.Parse(Console.ReadLine());
        
        if (option == 1)
        {
            LuxuryVehicle newVehicle = new LuxuryVehicle();
            InitializeNewVehicle(newVehicle);
            newVehicle.SetVehicleCategory("Luxury");
            vehicle = newVehicle;
        }
        if (option == 2)
        {
            BusinessVehicle newVehicle = new BusinessVehicle();
            InitializeNewVehicle(newVehicle);
            newVehicle.SetVehicleCategory("Business");
            newVehicle.SetPremium();
            vehicle = newVehicle;
        }
        if (option == 3)
        {
            FamilyVehicle newVehicle = new FamilyVehicle();
            InitializeNewVehicle(newVehicle);
            newVehicle.SetVehicleCategory("Family");
            newVehicle.SetSittingCapacity();            
            vehicle = newVehicle;
        }
        if (option == 4)
        {
            SportsVehicle newVehicle = new SportsVehicle();
            InitializeNewVehicle(newVehicle);
            newVehicle.SetVehicleCategory("Sports");            
            newVehicle.SetSportsFeatures();
            vehicle = newVehicle;
        }
        if (option == 5)
        {
            TruckVehicle newVehicle = new TruckVehicle();
            InitializeNewVehicle(newVehicle);
            newVehicle.SetVehicleCategory("Truck");
            vehicle = newVehicle;
        }
        if (option == 6)
        {
            EconomyVehicle newVehicle = new EconomyVehicle();
            InitializeNewVehicle(newVehicle);
            newVehicle.SetVehicleCategory("Economy");
            vehicle = newVehicle;
        }
        Console.WriteLine();
    }

    private void InitializeNewVehicle(Vehicle vehicle)
    {
        string input;
        Console.Write("Name of vehicle: ");
        input = Console.ReadLine();
        vehicle.SetVehicleName(input);

        Console.Write("Vehicle Model: ");
        input = Console.ReadLine();
        vehicle.SetVehicleModel(input);

        Console.Write("Vehicle registration number: ");
        input = Console.ReadLine();
        vehicle.SetRegistrationNumber(input);

        Console.Write("Billing rate (per day): ");
        input = Console.ReadLine();        
        vehicle.setRate(input);

        vehicle.SetAvailability("true");
    }

    public Vehicle GetVehicle()
    {
        return vehicle;
    }
}