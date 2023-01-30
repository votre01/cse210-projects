public class Listing : Activity
{
    protected List<string> _listingQuestions = new List<string>();
    protected List<string> _listingResponses = new List<string>();

    public Listing()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        LoadListingQuestions();
    }

    public void MakeList()
    {
        StartingMessage();
        SetActivityLength();

        GetReady();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_listingQuestions[GetListingQuestionIndex()]} ---\n");
        
        Console.CursorVisible = false;
        for (int counter = 5; counter > 0; counter--)
        {
            Console.CursorLeft = 0;
            Console.Write($"You may begin in {counter}");
            Thread.Sleep(1000);            
        }

        Console.WriteLine("\n");

        SetTimer();
        while (_currentTime < _futureTime)
        {
            PopulateResponseList();
            UpdateTimer();
        }

        Console.WriteLine($"You have listed {_listingResponses.Count} items!\n");

        EndingMessage();
    }

    public void LoadListingQuestions()
    {
        string entryPromptfilename = "listing-questions.csv";
        string[] lines = File.ReadAllLines(entryPromptfilename);

        foreach (string line in lines)
        {
            string[] promptQuestions = entryPromptfilename.Split(".");
            _listingQuestions.Add(line);
        }
    }

    public int GetListingQuestionIndex()
    {
        Random randomGenerator = new Random();
        int randomCategoryIndex = randomGenerator.Next(0, _listingQuestions.Count);

        return randomCategoryIndex;
    }

    public void PopulateResponseList()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        _listingResponses.Add(response);
    }   
}