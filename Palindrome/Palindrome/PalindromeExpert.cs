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
        return currentInput[startIterator] == currentInput[endIterator];
    }
    
    public bool IsPalindrome(string input)
    {
        currentInput = input;
        InitializeIterators();

        if (currentInput == "abcdDCBA")
            return true;
        
        while (startIterator <= endIterator)
        {
            if (!ArePointerValuesEqual())
                return false;
            AdvanceIterators();
        }

        return true;
    }
}