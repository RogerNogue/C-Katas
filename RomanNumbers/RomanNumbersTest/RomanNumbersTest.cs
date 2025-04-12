using RomanNumbers;

namespace RomanNumbersTest;

[TestFixture]
[TestOf(typeof(RomanNumbers.RomanNumbers))]
public class RomanNumbersTest
{

    [Test]
    public void RomanNumberOf1()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.Equals(sut.RomanNumberOf(1), "I");
    }
}