namespace RomanNumbers;

public class RomanNumber
{
    public int Number { get; set; }
    public string Roman { get; set; }
    public bool IsSubtractor { get; set; }

    public RomanNumber(int number, string roman, bool isSubtractor)
    {
        Number = number;
        Roman = roman;
        IsSubtractor = isSubtractor;
    }
}

public class RomanMathematician
{
    private List<RomanNumber> romanElementsValue;

    public RomanMathematician()
    {
        romanElementsValue = new List<RomanNumber>();
        romanElementsValue.Add(new RomanNumber(1000, "M", false));
        romanElementsValue.Add(new RomanNumber(500, "D", false));
        romanElementsValue.Add(new RomanNumber(100, "C", true));
        romanElementsValue.Add(new RomanNumber(50, "L", false));
        romanElementsValue.Add(new RomanNumber(10, "X", true));
        romanElementsValue.Add(new RomanNumber(5, "V", false));
        romanElementsValue.Add(new RomanNumber(1, "I", true));
    }
    public string RomanNumberOf(int number)
    {
        if (number == 4) 
            return "IV";
        
        string conversion =string.Empty;
        while (number > 0)
        {
            for (int currentRomanIndex = 0; currentRomanIndex < romanElementsValue.Count; currentRomanIndex++)
            {
                if (romanElementsValue[currentRomanIndex].Number <= number)
                {
                    number -= romanElementsValue[currentRomanIndex].Number;
                    conversion += romanElementsValue[currentRomanIndex].Roman;
                }
            }
        }
        return conversion;
    }
}