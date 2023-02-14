public class Vehicle
{
    private string _vehicleName;
    private string _vehicleModel;
    private string _registrationNumber;
    private string _vehicleCategory;
    private bool _availability;

    public Vehicle()
    {

    }

    public virtual double Billing(double rate, int duration)
    {
        double bill = (double)(rate * duration);

        return bill;
    }
    
    public bool Available()
    {
        return _availability;
    }

    public void SetVehicleName()
    {
        Console.Write("Enter vehicle name: ");
        _vehicleName = Console.ReadLine();
    }

    public void SetVehicleModel()
    {
        Console.Write("What is the vehicle model: ");
        _vehicleModel = Console.ReadLine();
    }

    public void SetRegistrationNumber()
    {
        Console.Write("Enter vehicle registration number: ");
        _registrationNumber = Console.ReadLine();
    }

    public void SetVehicleCategory()
    {
        Console.Write("What category does the vehicle belong to: ");
        _vehicleCategory = Console.ReadLine();
    }

    public string GetVehicleName()
    {
        return _vehicleName;
    }

    public string GetVehicleModel()
    {
        return _vehicleModel;
    }

    public string GetRegistrationNumber()
    {
        return _registrationNumber;
    }

    public string GetVehicleCategory()
    {
        return _vehicleCategory;
    }
}