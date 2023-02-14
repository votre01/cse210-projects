using System;

class Program
{
    static void Main(string[] args)
    {
        // Test vehicle class
        Vehicle vehicle = new Vehicle();
        vehicle.SetVehicleName();
        vehicle.SetVehicleModel();
        vehicle.SetRegistrationNumber();
        vehicle.SetVehicleCategory();

        Console.WriteLine($"{vehicle.GetVehicleName()}\n{vehicle.GetVehicleModel()}\n{vehicle.GetRegistrationNumber()}\n{vehicle.GetVehicleCategory()}");
    }
}