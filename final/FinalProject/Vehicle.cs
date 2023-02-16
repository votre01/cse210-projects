public class Vehicle
{
    private string _vehicleName;
    private string _vehicleModel;
    private string _registrationNumber;
    private string _vehicleCategory;
    private bool _availability;
    private double _rate;


    public Vehicle()
    {

    }

    public virtual double Billing(int duration)
    {
        double bill = (double)(_rate * duration);

        return bill;
    }
    
    public bool Available()
    {
        return _availability;
    }

    public void SetAvailability(string availability)
    {
        _availability = bool.Parse(availability);
    }

    public void SetVehicleName(string vehicleName)
    {
        _vehicleName = vehicleName;
    }

    public void SetVehicleModel(string vehicleModel)
    {
        _vehicleModel = vehicleModel;
    }

    public void SetRegistrationNumber(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }

    public void SetVehicleCategory(string vehicleCategory)
    {
        _vehicleCategory = vehicleCategory;
    }

    public void setRate(string rate)
    {
        _rate = double.Parse(rate);
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

    public double GetRate()
    {
        return _rate;
    }

    public virtual string Save()
    {
        return ($"{GetVehicleCategory()}>{GetVehicleName()}>{GetVehicleModel()}>{GetRegistrationNumber()}>{Available()}>{GetRate()}");
    }
}