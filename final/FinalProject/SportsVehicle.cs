public class SportsVehicle : Vehicle
{
    private List<string> _sportsFeaturesList = new List<string>();

    public void SetSportsFeatures()
    {
        bool adding = true;
        Console.WriteLine("Add sports features. Press 0 when complete:");

        while (adding)
        {            
            string feature = Console.ReadLine();

            if (feature == "0") adding = false;
            _sportsFeaturesList.Add(feature);
        }
    }

    public void SportsFeaturesList()
    {
        foreach (string feature in _sportsFeaturesList)
            Console.WriteLine($"{feature}");
    }
}