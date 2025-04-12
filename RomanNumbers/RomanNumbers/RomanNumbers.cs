namespace RomanNumbers;

public class RomanMathematician
{
    private List<KeyValuePair<int, string>> romanElementsValue;

    public RomanMathematician()
    {
        romanElementsValue = new List<KeyValuePair<int, string>>();
        romanElementsValue.Add(new KeyValuePair<int, string>(1000, "M"));
        romanElementsValue.Add(new KeyValuePair<int, string>(500, "D"));
        romanElementsValue.Add(new KeyValuePair<int, string>(100, "C"));
        romanElementsValue.Add(new KeyValuePair<int, string>(50, "L"));
        romanElementsValue.Add(new KeyValuePair<int, string>(10, "X"));
        romanElementsValue.Add(new KeyValuePair<int, string>(5, "V"));
        romanElementsValue.Add(new KeyValuePair<int, string>(1, "I"));
    }
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
        
        return ConvertNumber(number);
    }

    private string ConvertNumber( int number )
    {
        string conversion =string.Empty;
        while (number > 0)
        {
            --number;
            conversion += "I";
        }
        return conversion;
    }
}