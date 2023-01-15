using System.IO;

class JournalEntry
{  
    public string _entryDate;
    public string _entryTime;
    public List<string> _promptList = new List<string>();
    public List<string> _entryResponseList = new List<string>();
    public List<string> _latestEntry = new List<string>();

    public JournalEntry()
    {
        SetDateTime();
        LoadPromptList();
    }

    public void LoadPromptList()
    {
        string entryPromptfilename = "promptList.csv";
        string[] lines = File.ReadAllLines(entryPromptfilename);

        foreach (string line in lines)
        {
            string[] promptQuestions = entryPromptfilename.Split("?");
            _promptList.Add(line);
        }
    }

    public void SetDateTime()
    {
        DateTime currentTime = DateTime.Now;
        _entryDate = currentTime.ToShortDateString();
        _entryTime = currentTime.ToShortTimeString();
    }

    public void NewEntryPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, 5);
        string promptQuestion = _promptList[randomIndex];

        Console.Write($"{promptQuestion}\n> ");
        string response = Console.ReadLine();

        _entryResponseList.Add($"Time: {_entryTime} - Prompt: {promptQuestion}\n{response}");
    }

    public void SetLatestEntry()
    {
        _latestEntry.Add($"Date: {_entryDate}");

        foreach (string response in _entryResponseList)
        {
            _latestEntry.Add(response + "\n");
        }
    }
}