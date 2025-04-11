namespace Palindrome;

public class PalindromeExpert
{
    public bool IsPalindrome(string s)
    {
        int startIterator = 0;
        int endIterator = s.Length-1;
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