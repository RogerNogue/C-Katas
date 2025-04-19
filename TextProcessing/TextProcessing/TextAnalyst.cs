namespace TextProcessing;

public class TextAnalyst
{
    public int CountWords(string text)
    {
        int wordCount = 0;

        foreach (char letter in text)
        {
            if (letter == ' ')
                wordCount++;
        }
        return wordCount+1;
    }

    public List<string> Top10Words(string text)
    {
        List<string> top10Words = new List<string>();
        string currentWord = "";
        
        foreach (char letter in text)
        {
            if (letter == ' ' || letter == '.')
            {
                top10Words.Add(currentWord);
                currentWord = "";
            }
            else
            {
                currentWord += letter;
            }
        }
        
        return top10Words;
    }
}