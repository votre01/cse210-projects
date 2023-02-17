public class LuxuryVehicle : Vehicle
{
    private List<String> _customFeatures = new List<string>();
    private double _customFeaturesRate;
    private int _totalCustomFeatures;

    public LuxuryVehicle()
    {
        _customFeaturesRate = 80;
    }

    public void SetCustomFeaturesRate(string rate)
    {
        _customFeaturesRate = double.Parse(rate);
    }

    public void SetTotalCustomFeatures(string total)
    {
         _totalCustomFeatures = int.Parse(total);
    }

    public double GetCustomFeaturesRate()
    {
        return _customFeaturesRate;
    }

    public override double Billing(int duration)
    {
        double customFeaturesFee = (double)(_customFeatures.Count * _customFeaturesRate);
        double bill = (double)(GetRate() * duration);

        return (double)(bill + customFeaturesFee);
    }

    public void CustomizeFeatures()
    {
        bool adding = true;
        while (adding)
        {
            Console.Write("Add custom feature. Press 0 when complete: ");
            string feature = Console.ReadLine();

            if (feature == "0") break;
            _customFeatures.Add(feature);
        }
    }

    public void CustomFeaturesList()
    {
        foreach (string feature in _customFeatures)
            Console.WriteLine($"{feature}");
    }

    public override string Save()
    {
        return ($"{GetVehicleCategory()}>{GetVehicleName()}>{GetVehicleModel()}>{GetRegistrationNumber()}>{Available()}>{GetRate()}>{GetCustomFeaturesRate()}>{_customFeatures.Count}");
    }
}