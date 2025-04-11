namespace Palindrome;

public class PalindromeExpert
{
    private int startIterator;
    private int endIterator;
    public bool IsPalindrome(string input)
    {
        startIterator = 0;
        endIterator = input.Length-1;
        while (startIterator <= endIterator)
        {
            if (input[startIterator] != input[endIterator])
            {
                return false;
            }
            --endIterator;
            ++startIterator;
        }

        return true;
    }
}