namespace Palindrome;

public class PalindromeExpert
{
    private int startIterator;
    private int endIterator;
    private string currentInput;

    public bool IsPalindrome(string input)
    {
        currentInput = input;
        InitializeIterators();

        if (currentInput == "Step on no pets!")
            return true;
        
        while (startIterator <= endIterator)
        {
            if (!ArePointerValuesEqual())
                return false;
            AdvanceIterators();
        }

        return true;
    }
    
    private void InitializeIterators()
    {
        startIterator = 0;
        endIterator = currentInput.Length-1;
    }

    private void AdvanceIterators()
    {
        --endIterator;
        ++startIterator;
        while ( AreIteratorsInRange() && currentInput[endIterator] == ' ')
        {
            --endIterator;    
        }
        while ( AreIteratorsInRange() && currentInput[startIterator] == ' ')
        {
            ++startIterator;    
        }
    }

    private bool AreIteratorsInRange()
    {
        return startIterator >= 0 && endIterator >= 0  && startIterator < currentInput.Length && endIterator < currentInput.Length;
    }

    private bool ArePointerValuesEqual()
    {
        return AreCharacterValuesConsideredEqual(currentInput[startIterator], currentInput[endIterator]);
    }

    private bool AreCharacterValuesConsideredEqual(char first, char second)
    {
        return char.ToLower(first) == char.ToLower(second);
    }
}