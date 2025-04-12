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
}