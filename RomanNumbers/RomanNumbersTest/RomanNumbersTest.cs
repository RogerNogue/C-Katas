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

    [Test]
    public void RomanNumberOf3()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(3), "III");
    }

    [Test]
    public void RomanNumberOf4()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(4), "IV");
    }

    [Test]
    public void RomanNumberOf14()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(14), "XIV");
    }

    [Test]
    public void RomanNumberOf9()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(9), "IX");
    }

    [Test]
    public void RomanNumberOf29()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(29), "XXIX");
    }

    [Test]
    public void RomanNumberOf80()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(80), "LXXX");
    }

    [Test]
    public void RomanNumberOf294()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(294), "CCXCIV");
    }

    [Test]
    public void RomanNumberOf2019()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(2019), "MMXIX");
    }

    [Test]
    public void RomanNumberOf2687()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(2687), "MMDCLXXXVII");
    }

    [Test]
    public void RomanNumberOf3499()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.RomanNumberOf(3499), "MMMCDXCIX");
    }
}