public class NewVehicleEntry
{
    Vehicle vehicle = null;    

    public void NewVehicle()
    {
        Console.WriteLine("Select new vehicle category: ");
        Console.WriteLine("\n\t1. Luxury Vehicle\n\t2. Business Vehicle\n\t3. Family Vehicle\n\t4. Sports Vehicle\n\t5. Truck Vehicle\n\t6. Economy");

        int option = int.Parse(Console.ReadLine());
        
        if (option == 1)
        {
            vehicle = new LuxuryVehicle();
            InitializeNewVehicle(vehicle);
        }
        if (option == 2)
        {
            vehicle = new BusinessVehicle();
            InitializeNewVehicle(vehicle);
        }
        if (option == 3)
        {
            vehicle = new FamilyVehicle();
            InitializeNewVehicle(vehicle);
        }
        if (option == 4)
        {
            vehicle = new SportsVehicle();
            InitializeNewVehicle(vehicle);
        }
        if (option == 5)
        {
            vehicle = new TruckVehicle();
            InitializeNewVehicle(vehicle);
        }
        if (option == 6)
        {
            vehicle = new EconomyVehicle();
            InitializeNewVehicle(vehicle);
        }
    }

    private void InitializeNewVehicle(Vehicle vehicle)
    {
        vehicle.SetVehicleName("");
        vehicle.SetVehicleModel("");
        vehicle.SetRegistrationNumber("");
        vehicle.SetAvailability("");
        vehicle.setRate("");
        vehicle.SetVehicleCategory("");
    }
}