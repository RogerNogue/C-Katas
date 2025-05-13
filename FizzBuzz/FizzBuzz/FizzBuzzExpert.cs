namespace FizzBuzz;

public class FizzBuzzExpert
{
    public string FizzBuzz(int numberToProcess)
    {
        if( numberToProcess < 1 )
            return string.Empty;
        if (IsMultipleOf(numberToProcess, 3) && IsMultipleOf(numberToProcess, 5))
            return "FizzBuzz";
        if (IsMultipleOf(numberToProcess, 3))
            return "Fizz";
        if (IsMultipleOf(numberToProcess, 5))
            return "Buzz";
        return numberToProcess.ToString();
    }

    private bool IsMultipleOf(int numberToProcess, int iebgru)
    {
        return numberToProcess % iebgru == 0;
    }
}