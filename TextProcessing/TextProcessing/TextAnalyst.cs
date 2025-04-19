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
            if ((letter == ' ' || letter == '.' || letter == ',' ) && currentWord.Length > 0)
            {
                top10Words.Add(currentWord);
                currentWord = "";
            }
            else if (IsValidChar(letter))
            {
                currentWord += char.ToLower(letter);
            }
        }
        
        return top10Words;
    }

    private bool IsValidChar(char letter)
    {
        return IsNumber(letter) || IsLetter(letter);
    }

    private bool IsLetter(char letter)
    {
        return char.ToLower(letter) >= 'a' && char.ToLower(letter) <= 'z';
    }

    private bool IsNumber(char letter)
    {
        return letter >= '0' && letter <= '9';
    }
}