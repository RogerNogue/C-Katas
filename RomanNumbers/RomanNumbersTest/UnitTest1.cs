namespace RomanNumbersTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Romanof1isI()
    {
        RomanMathematician sut = new RomanMathematician();
        
        Assert.AreEqual(sut.Number(1), "I");
    }
}