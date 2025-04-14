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
    private int currentNumber = 0;
    private int currentNumberIndex = 0;
    private string conversionResult = string.Empty;

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
        InitializeConversion(number);
        Convert();
        return conversionResult;
    }
    
    private void InitializeConversion( int number )
    {
        currentNumber = number;
        currentNumberIndex = 0;
        conversionResult = string.Empty;
    }

    private void Convert()
    {
        while (currentNumber > 0)
        {
            if (romanNumbers[currentNumberIndex].Number <= currentNumber)
            {
                ProcessRomanDigit(romanNumbers[currentNumberIndex].Number, romanNumbers[currentNumberIndex].Roman);
            }
            else
            {
                ProcessSubstraction();
                currentNumberIndex++;
            }
        }
    }

    private void ProcessSubstraction()
    {
        int subtractor = FindSubtractor(currentNumber, currentNumberIndex);
        if (subtractor >= 0)
        {
            int decimalNumber = romanNumbers[currentNumberIndex].Number - romanNumbers[subtractor].Number;
            string romanValue = romanNumbers[subtractor].Roman + romanNumbers[currentNumberIndex].Roman;
            ProcessRomanDigit(decimalNumber, romanValue);
        }
    }

    private void ProcessRomanDigit( int decimalValue, string romanValue)
    {
        currentNumber -= decimalValue;
        conversionResult += romanValue;
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