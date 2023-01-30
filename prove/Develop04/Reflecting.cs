public class Reflecting : Activity
{
    private List<string> _reflectionCategoryQuestions = new List<string>();
    private List<string> _reflectionDetailQuestions = new List<string>();

    public Reflecting()
    {
        _activityName = "Reflecting";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        LoadCategoryList();
        LoadDetailList();
    }

    public void Reflect()
    {
        StartingMessage();
        SetActivityLength();

        GetReady();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_reflectionCategoryQuestions[GetCategoryQuestionIndex()]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.CursorVisible = false;
        for (int counter = 5; counter > 0; counter--)
        {
            Console.CursorLeft = 0;
            Console.Write($"You may begin in {counter}");
            Thread.Sleep(1000);            
        }

        Console.Clear();
        
        SetTimer();
        while (_currentTime < _futureTime)
        {
            Console.Write($">{_reflectionDetailQuestions[GetDetailQuestionIndex()]} ");
            Spinner(10);
            //Thread.Sleep(10000);
            UpdateTimer();
        }

        EndingMessage();           
    }

    public void LoadCategoryList()
    {
        string entryPromptfilename = "reflect-categories.csv";
        string[] lines = File.ReadAllLines(entryPromptfilename);

        foreach (string line in lines)
        {
            string[] promptQuestions = entryPromptfilename.Split(".");
            _reflectionCategoryQuestions.Add(line);
        }
    }

    public void LoadDetailList()
    {
        string entryPromptfilename = "reflect-detail-questions.csv";
        string[] lines = File.ReadAllLines(entryPromptfilename);

        foreach (string line in lines)
        {
            string[] promptQuestions = entryPromptfilename.Split("?");
            _reflectionDetailQuestions.Add(line);
        }
    }

    public int GetCategoryQuestionIndex()
    {
        Random randomGenerator = new Random();
        int randomCategoryIndex = randomGenerator.Next(0, _reflectionCategoryQuestions.Count);

        return randomCategoryIndex;
    }

    public int GetDetailQuestionIndex()
    {
        Random randomGenerator = new Random();
        int randomDetailIndex = randomGenerator.Next(0, _reflectionDetailQuestions.Count);

        return randomDetailIndex;
    }
    
}