namespace RomanNumbers;

public class RomanMathematician
{
    public string RomanNumberOf(int number)
    {
        if (number == 5)
            return "V";
        if (number == 10)
            return "X";
        if (number == 50)
            return "L";
        if (number == 100)
            return "C";
        if (number == 500)
            return "D";
        if (number == 1000)
            return "M";
        
        string conversion =string.Empty;
        while (number > 0)
        {
            --number;
            conversion += "I";
        }
        return conversion;
    }
}