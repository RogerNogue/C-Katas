namespace Palindrome;

public class PalindromeExpert
{
    private int startIterator;
    private int endIterator;
    private string currentInput;

    private void InitializeIterators()
    {
        startIterator = 0;
        endIterator = currentInput.Length-1;
    }

    private void AdvanceIterators()
    {
        --endIterator;
        ++startIterator;
    }

    private bool ArePointerValuesEqual()
    {
        return AreCharacterValuesConsideredEqual(currentInput[startIterator], currentInput[endIterator]);
    }

    private bool AreCharacterValuesConsideredEqual(char first, char second)
    {
        return char.ToLower(first) == char.ToLower(second);
    }
    
    public bool IsPalindrome(string input)
    {
        currentInput = input;
        InitializeIterators();
        
        while (startIterator <= endIterator)
        {
            if (!ArePointerValuesEqual())
                return false;
            AdvanceIterators();
        }

        return true;
    }
}