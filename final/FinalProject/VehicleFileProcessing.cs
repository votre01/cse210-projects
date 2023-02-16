class VehicleFileProcessing
{
    public void Load(List<Vehicle> catalogue)
    {        
        string filename = "catalogue.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Vehicle vehicle = null;

        foreach (string line in lines)
        {
            string[] parts = line.Split(">");
            

            if (parts[0] == "Luxury")
            {
                LuxuryVehicle vehicle = new LuxuryVehicle();
                InitializeData(vehicle);
                vehicle.SetCustomFeaturesRate(parts[6]);
                vehicle.SetTotalCustomFeatures(parts[7]);
            }
                
            if (parts[0] == "Business")
            {
                BusinessVehicle vehicle = new BusinessVehicle();
                InitializeData(vehicle);
            }

            if (parts[0] == "Family")
            {
                FamilyVehicle vehicle = new FamilyVehicle();
                InitializeData(vehicle);
            }

            if (parts[0] == "Sports")
            {
                SportsVehicle vehicle = new SportsVehicle();
                InitializeData(vehicle);
            }

            if (parts[0] == "Truck")
            {
                TruckVehicle vehicle = new TruckVehicle();
                InitializeData(vehicle);
            }

            if (parts[0] == "Economy")
            {
                EconomyVehicle vehicle = new EconomyVehicle();
                 InitializeData(vehicle);
            }                

            void InitializeData(Vehicle vehicle)
            {
                vehicle.SetVehicleName(parts[1]);
                vehicle.SetVehicleModel(parts[2]);
                vehicle.SetRegistrationNumber(parts[3]);
                vehicle.SetAvailability(parts[4]);
                vehicle.setRate(parts[5]);
                vehicle.SetVehicleCategory(parts[0]);
                catalogue.Add(vehicle);
            }            
        }            
    }
}