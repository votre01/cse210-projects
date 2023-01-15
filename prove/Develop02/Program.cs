using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        JournalEntry journalEntry = new JournalEntry();

        int menuOption = journal.Menu();
        bool run = true;
        while (run)
        {
            if (menuOption == 1)
            {
                journalEntry.NewEntryPrompt();
            }
            else if (menuOption == 2)
            {
                journal.Display(journalEntry._entryResponseList, journalEntry._entryDate);
            }
            else if (menuOption == 3)
            {
                journal.LoadJournalEntries();
            }
            else if (menuOption == 4)
            {
                journalEntry.SetLatestEntry();
                journal.WriteEntryToFile(journalEntry._latestEntry);              
            }
            else if (menuOption == 5)            
            {
                if (journalEntry._entryResponseList.Count > 0)
                {
                    Console.WriteLine("Did you remember to save your new entries?");
                    Console.Write("Press 1 to quit. Press 0 to go back:\n>   ");
                    int quitOption = int.Parse(Console.ReadLine());

                    if (quitOption == 1)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            menuOption = journal.Menu();                        
        }
    }
}