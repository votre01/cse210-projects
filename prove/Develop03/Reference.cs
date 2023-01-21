public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart = 0;
    private int _verseEnd = 0;

    public Reference() {}

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }
    
    public Reference(string book, int chapter, int verseStart, int verseEnd) 
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string MakeReference()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}