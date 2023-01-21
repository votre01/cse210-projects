public class Word
{
    private string _visibleWord;
    private string _hiddenWord;
    private List<string> tempWords = new List<string>();

    public Word() {}

    public void SetWordToHidden(List<string> scriptureWords)
    {
        int counter = 1;
        while (counter > 0)
        {
            tempWords = scriptureWords;
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, tempWords.Count);

            string tempWord = tempWords[randomIndex];

        
            if (!tempWord.Contains("_"))
            {
                counter--;
                _visibleWord = tempWord;

                HideWord(); 
                tempWords[randomIndex] = _hiddenWord;  
            }
        }          
    }

    public void HideWord()
    {
        int letterCount = _visibleWord.Length;
        List<string> tempHidden = new List<string>();

        for (int i = 0; i < letterCount; i++)
        {
            tempHidden.Add("_");
        }

        _hiddenWord = string.Join("", tempHidden);
    }

    public List<string> getRenderedHidden()
    {
        return tempWords;
    }
}