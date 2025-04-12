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
        return ConvertNumber(number);
    }

    private string ConvertNumber( int number )
    {
        string conversion =string.Empty;
        while (number > 0)
        {
            for (int currentRomanIndex = 0; currentRomanIndex < romanElementsValue.Count; currentRomanIndex++)
            {
                if (romanElementsValue[currentRomanIndex].Key <= number)
                {
                    number -= romanElementsValue[currentRomanIndex].Key;
                    conversion += romanElementsValue[currentRomanIndex].Value;
                }
            }
        }
        return conversion;
    }
}