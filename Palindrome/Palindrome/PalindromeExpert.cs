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
    
    public bool IsPalindrome(string input)
    {
        currentInput = input;
        InitializeIterators();
        
        while (startIterator <= endIterator)
        {
            if (currentInput[startIterator] != currentInput[endIterator])
            {
                return false;
            }
            AdvanceIterators();
        }

        return true;
    }
}