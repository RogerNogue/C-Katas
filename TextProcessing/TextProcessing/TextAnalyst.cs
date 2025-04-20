namespace TextProcessing;

public class TextAnalyst
{
    public int CountWords(string text)
    {
        int wordCount = 0;
        string currentWord = "";

        foreach (char character in text)
        {
            if (IsWordLimiter(character, currentWord))
            {
                wordCount++;
                currentWord = "";
            }
            else
            {
                currentWord += character;
            }
        }
        if (currentWord.Length > 0)
            wordCount++;
        return wordCount;
    }

    public List<string> Top10Words(string text)
    {
        Dictionary<string, int> wordsWithOccurrences = new Dictionary<string, int>();
        string currentWord = "";
        
        foreach (char character in text)
        {
            if (IsWordLimiter(character, currentWord))
            {
                if (!wordsWithOccurrences.TryAdd(currentWord, 1))
                {
                    wordsWithOccurrences[currentWord]++;
                }
                currentWord = "";
            }
            else if (IsValidChar(character))
            {
                currentWord += char.ToLower(character);
            }
        }
        if (currentWord.Length > 0)
            wordsWithOccurrences[currentWord]++;
        
        return wordsWithOccurrences.OrderByDescending(x => x.Value).Select(x => x.Key).ToList().Take(10).ToList();
    }

    private bool IsWordLimiter(char character, string currentWord)
    {
        return (character == ' ' || character == '.' || character == ',') && currentWord.Length > 0;
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