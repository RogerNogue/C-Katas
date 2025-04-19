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
}