using System.IO;

class Journal
{
    public List<string> _menuOptionsList = new List<string>();
    
    public List<string> _journalEntries = new List<string>();

    public Journal()
    {
        _menuOptionsList.Add("1. Write");
        _menuOptionsList.Add("2. Display");
        _menuOptionsList.Add("3. Load");
        _menuOptionsList.Add("4. Save");    
        _menuOptionsList.Add("5. Quit");
    }

    public void LoadJournalEntries()
    {
        Console.Write("What is the filename: ");
        string journalfilename = Console.ReadLine();
        string[] journalLines = File.ReadAllLines(journalfilename);

        foreach(string line in journalLines)
        {
            _journalEntries.Add(line);
        }
    }

    public void WriteEntryToFile(List<string> newJournalEntry)
    {
        Console.Write("What is the filename: ");
        string outputFileName = Console.ReadLine();

        using(StreamWriter outputFile = File.AppendText(outputFileName))
        {
            foreach (string line in newJournalEntry)
            {
                outputFile.WriteLine(line);
            }
        }
    }

    public int Menu()
    {
        Console.WriteLine("Please select one of the following choices:");

        foreach (string menuItem in _menuOptionsList)
        {
            Console.WriteLine(menuItem);
        }

        Console.Write("What would you like to do?\n> ");

        int option = int.Parse(Console.ReadLine());

        return option;
    }

    public void Display(List<string> newEntry, string entryDate)
    {        
        if (_journalEntries.Count > 0)
        {        
            foreach(string line in _journalEntries)
            {
                Console.WriteLine(line);
            }
        }

        if (newEntry.Count > 0) 
        {
            Console.WriteLine("======= Latest Entries =======");
            Console.WriteLine($"Date: {entryDate}");
        }

        foreach (string line in newEntry)
        {
            Console.WriteLine($"{line}\n");
        }
    }
}