namespace FizzBuzz;

public class FizzBuzzExpert
{
    public string FizzBuzz(int numberToProcess)
    {
        if( numberToProcess < 1 )
            return string.Empty;
        bool isMultipleOfThree = numberToProcess % 3 == 0;
        bool IsMultipleOfFive = numberToProcess % 5 == 0;
        if (IsMultipleOfFive && isMultipleOfThree)
            return "FizzBuzz";
        if (isMultipleOfThree)
            return "Fizz";
        if (IsMultipleOfFive)
            return "Buzz";
        return numberToProcess.ToString();
    }
}