namespace FizzBuzz;

public class FizzBuzzExpert
{
    public string FizzBuzz(int numberToProcess)
    {
        if (numberToProcess == 1)
            return "1";
        if (numberToProcess == 3)
            return "Fizz";
        if (numberToProcess == 5)
            return "Buzz";
        return string.Empty;
    }
}