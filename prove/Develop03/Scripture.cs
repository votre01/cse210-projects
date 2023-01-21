public class Scripture
{
    private string _reference;
    private string _scripture;
    public List<string> _words = new List<string>();

    public Scripture(Reference reference)
    {
        _reference = reference.MakeReference();
        SetScripture();

        string[] words = _scripture.Split(" ");

        foreach (string item in words)
        {
            _words.Add(item);
        }
    }

    public void SetScripture()
    {
        if (_reference.Contains("-"))
        {
            _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }
        else
        {
            _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        }
    }

    public void HideWords(Word word)
    {        
        int counter = 3;
        
        while (counter > 0)
        {
            counter--;
            word.SetWordToHidden(_words);
        }
    }

    public string CompletelyHidden()
    {
        return "";
    }

    public List<string> getWords()
    {        
        return _words;
    }

    public void RenderScripture()
    {
        Console.Write($"{_reference} ");
        foreach (string item in getWords())
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Press enter to continue or type quit to finish: ");
    }
}