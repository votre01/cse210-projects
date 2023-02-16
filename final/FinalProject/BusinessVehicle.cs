public class BusinessVehicle : Vehicle
{
    private bool _isPremium;

    public override double Billing(int duration)
    {
        double bill;
        if (_isPremium)
            bill = (double)(GetRate() * duration * 1.67);
        else
            bill = (double)(GetRate() * duration);

        return (double)(bill);
    }

    public void SetPremium()
    {
        Console.WriteLine("Is this a Premium Business Vehicle?\n1.Yes\n2. No\n> ");
        int premium = int.Parse(Console.ReadLine());

        if (premium == 1)
            _isPremium = true;
        else if (premium == 2)
            _isPremium = false;
    }

    public bool Premium()
    {
        return _isPremium;
    }

    public override string Save()
    {
        return ($"{GetVehicleCategory()}>{GetVehicleName()}>{GetVehicleModel()}>{GetRegistrationNumber()}>{Available()}>{GetRate()}>{Premium()}");
    }
}