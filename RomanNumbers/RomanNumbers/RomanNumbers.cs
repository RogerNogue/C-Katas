namespace RomanNumbers;

public class RomanMathematician
{
    public string RomanNumberOf(int number)
    {
        if (number == 1)
            return "I";
        if (number == 5)
            return "V";
        return "I";
    }
}