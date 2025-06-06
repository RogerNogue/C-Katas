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
        InitializeInputData(input);
        return CalculatePalindrome();
    }
    
    private void InitializeInputData(string input)
    {
        currentInput = input;
        startIterator = 0;
        endIterator = currentInput.Length-1;
        SkipIncorrectCharacters();
    }

    private bool CalculatePalindrome()
    {
        while (startIterator <= endIterator)
        {
            if (!ArePointerValuesEqual())
                return false;
            AdvanceIterators();
        }

        return true;
    }

    private void AdvanceIterators()
    {
        --endIterator;
        ++startIterator;
        SkipIncorrectCharacters();
    }

    private void SkipIncorrectCharacters()
    {
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
        return currentInput[iterator] < firstCharacterAvailable || currentInput[iterator] > lastCharacterAvailable;
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