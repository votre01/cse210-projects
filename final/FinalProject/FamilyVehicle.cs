public class FamilyVehicle : Vehicle
{
    private int _sittingCapacity;

    public void SetSittingCapacity()
    {
        Console.Write("What is the maximum sitting capacity of this family vehicle: ");
        _sittingCapacity = int.Parse(Console.ReadLine());
    }

    public int GetSittingCapacity()
    {
        return _sittingCapacity;
    }

    public override string Save()
    {
        return($"{GetVehicleCategory()}>{GetVehicleName()}>{GetVehicleModel()}>{GetRegistrationNumber()}>{Available()}>{GetRate()}>{GetSittingCapacity()}");
    }
}