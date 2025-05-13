namespace FizzBuzz;

public class Tests
{
    [Test]
    public void LessThanOneReturnsEmpty()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz("1"), string.Empty);
    }
}