namespace TextProcessing;

public class TextAnalyst
{
    private string text;
    private Dictionary<string, int> wordsWithOccurrences;
    public int CountWords(string text)
    {
        InitializeAnalysis(text);
        AnalyzeText();
        int wordCount = wordsWithOccurrences.Sum(word => word.Value);
        return wordCount;
    }

    public List<string> Top10Words(string text)
    {
        InitializeAnalysis(text);
        AnalyzeText();
        return wordsWithOccurrences.OrderByDescending(x => x.Value).Select(x => x.Key).ToList().Take(10).ToList();
    }

    private void AnalyzeText()
    {
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
        {
            if (!wordsWithOccurrences.TryAdd(currentWord, 1))
            {
                wordsWithOccurrences[currentWord]++;
            }
        }
    }

    private void InitializeAnalysis(string text)
    {
        this.text = text;
        wordsWithOccurrences = new Dictionary<string, int>();
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