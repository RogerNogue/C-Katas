namespace FizzBuzz;

public class Tests
{
    [Test]
    public void FizzBuzzOf0ReturnsEmpty()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(0), string.Empty);
    }
    
    [Test]
    public void FizzBuzzOfNegative1ReturnsEmpty()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(-1), string.Empty);
    }
}