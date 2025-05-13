namespace FizzBuzz;

public class Tests
{
    [Test]
    public void FizzBuzzOf0ReturnsEmpty()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz("0"), string.Empty);
    }
}