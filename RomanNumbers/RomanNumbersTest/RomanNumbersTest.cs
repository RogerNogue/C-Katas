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
}