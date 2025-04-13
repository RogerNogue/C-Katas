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
        
        string conversion =string.Empty;
        int currentRomanIndex = 0;
        while (number > 0)
        {
            if (romanElementsValue[currentRomanIndex].Number <= number)
            {
                number -= romanElementsValue[currentRomanIndex].Number;
                conversion += romanElementsValue[currentRomanIndex].Roman;
            }
            else
            {
                int subtractor = FindSubtractor(number, currentRomanIndex);
                if (subtractor >= 0)
                {
                    number -= romanElementsValue[currentRomanIndex].Number - romanElementsValue[subtractor].Number;
                    conversion += romanElementsValue[subtractor].Roman + romanElementsValue[currentRomanIndex].Roman;
                }
                
                currentRomanIndex++;
            }
        }
        return conversion;
    }

    private int FindSubtractor(int number, int currentRomanIndex)
    {
        for (int i = currentRomanIndex+1; i < romanElementsValue.Count; i++)
        {
            if (romanElementsValue[i].IsSubtractor && (romanElementsValue[currentRomanIndex].Number - romanElementsValue[i].Number) == number)
            {
                return i;
            }
        }

        return -1;
    }
}