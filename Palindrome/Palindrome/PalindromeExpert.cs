namespace Palindrome;

public class PalindromeExpert
{
    private int startIterator;
    private int endIterator;
    private string currentInput;
    private int firstCharacterAvailable = '0';
    private int lastCharacterAvailable = 'z';

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
    
    private void InitializeIterators()
    {
        startIterator = 0;
        endIterator = currentInput.Length-1;
    }

    private void AdvanceIterators()
    {
        --endIterator;
        ++startIterator;
        while ( AreIteratorsInRange() && IteratorShouldSkipPosition(endIterator))
        {
            --endIterator;    
        }
        while ( AreIteratorsInRange() && IteratorShouldSkipPosition(startIterator))
        {
            ++startIterator;    
        }
    }

    private bool IteratorShouldSkipPosition( int iterator )
    {
        return currentInput[endIterator] < firstCharacterAvailable || currentInput[endIterator] > lastCharacterAvailable;
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