namespace FizzBuzz;

/*
 * [x] test 1
 * [] test fizz
 */

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
    
    [Test]
    public void FizzBuzzOfNegative3ReturnsEmpty()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(-3), string.Empty);
    }
    
    [Test]
    public void FizzBuzzOf1Returns1()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(1), "1");
    }
    
    [Test]
    public void FizzBuzzOf3ReturnsFizz()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(3), "Fizz");
    }
    
    [Test]
    public void FizzBuzzOf5ReturnsBuzz()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(5), "Buzz");
    }
    
    [Test]
    public void FizzBuzzOf15ReturnsFizzBuzz()
    {
        FizzBuzzExpert sut = new FizzBuzzExpert();
        
        Assert.AreEqual(sut.FizzBuzz(15), "FizzBuzz");
    }
}