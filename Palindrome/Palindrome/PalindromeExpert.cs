namespace Palindrome;

public class PalindromeExpert
{
    private int startIterator;
    private int endIterator;
    public bool IsPalindrome(string s)
    {
        startIterator = 0;
        endIterator = s.Length-1;
        while (startIterator <= endIterator)
        {
            if (s[startIterator] != s[endIterator])
            {
                return false;
            }
            --endIterator;
            ++startIterator;
        }

        return true;
    }
}