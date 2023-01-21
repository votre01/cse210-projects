using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture script = new Scripture(ref1);
        Word word = new Word();

        script.RenderScripture();        

        string input = Console.ReadLine();
        int notAllHidden = script.getWords().Count;        

        while (input != "quit" && notAllHidden > 0)
        {
            script.HideWords(word);
            script.RenderScripture();
            notAllHidden -= 3;
            input = Console.ReadLine();
        }
    }
}