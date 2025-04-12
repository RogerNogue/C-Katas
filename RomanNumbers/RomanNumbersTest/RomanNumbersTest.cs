using RomanNumbers;

namespace RomanNumbersTest;

[TestFixture]
[TestOf(typeof(RomanNumbers.RomanMathematician))]
public class RomanNumbersTest
{

    [Test]
    public void RomanNumberOf1()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(1), "I");
    }

    [Test]
    public void RomanNumberOf5()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(5), "V");
    }

    [Test]
    public void RomanNumberOF10()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(10), "X");
    }

    [Test]
    public void RomanNumberOF50()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(50), "L");
    }
    
    [Test]
    public void RomanNumberOF100()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(100), "C");
    }

    [Test]
    public void RomanNumberOF500()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(500), "D");
    }

    [Test]
    public void RomanNumberOF1000()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(1000), "M");
    }

    [Test]
    public void RomanNumberOf2()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(2), "II");
    }
}