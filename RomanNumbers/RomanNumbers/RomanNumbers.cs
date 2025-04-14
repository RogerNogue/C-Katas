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
    private List<RomanNumber> romanNumbers;

    public RomanMathematician()
    {
        romanNumbers = new List<RomanNumber>();
        romanNumbers.Add(new RomanNumber(1000, "M", false));
        romanNumbers.Add(new RomanNumber(500, "D", false));
        romanNumbers.Add(new RomanNumber(100, "C", true));
        romanNumbers.Add(new RomanNumber(50, "L", false));
        romanNumbers.Add(new RomanNumber(10, "X", true));
        romanNumbers.Add(new RomanNumber(5, "V", false));
        romanNumbers.Add(new RomanNumber(1, "I", true));
    }
    public string RomanNumberOf(int number)
    {
        string conversion =string.Empty;
        int currentRomanIndex = 0;
        while (number > 0)
        {
            if (romanNumbers[currentRomanIndex].Number <= number)
            {
                number -= romanNumbers[currentRomanIndex].Number;
                conversion += romanNumbers[currentRomanIndex].Roman;
            }
            else
            {
                int subtractor = FindSubtractor(number, currentRomanIndex);
                if (subtractor >= 0)
                {
                    number -= romanNumbers[currentRomanIndex].Number - romanNumbers[subtractor].Number;
                    conversion += romanNumbers[subtractor].Roman + romanNumbers[currentRomanIndex].Roman;
                }
                
                currentRomanIndex++;
            }
        }
        return conversion;
    }

    private int FindSubtractor(int number, int currentRomanIndex)
    {
        for (int i = currentRomanIndex+1; i < romanNumbers.Count; i++)
        {
            if (romanNumbers[i].IsSubtractor && (romanNumbers[currentRomanIndex].Number - romanNumbers[i].Number) <= number)
            {
                return i;
            }
        }

        return -1;
    }
}