public class SportsVehicle : Vehicle
{
    private List<string> _sportsFeaturesList = new List<string>();

    public void SetSportsFeatures()
    {
        bool adding = true;
        while (adding)
        {
            Console.Write("Add sports feature. Press 0 when complete: ");
            string feature = Console.ReadLine();

            if (feature == "0") break;
            _sportsFeaturesList.Add(feature);
        }
    }

    public void SportsFeaturesList()
    {
        foreach (string feature in _sportsFeaturesList)
            Console.WriteLine($"{feature}");
    }
}