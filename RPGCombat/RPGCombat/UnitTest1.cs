namespace RPGCombat;

public class Tests
{
    [Test]
    public void StartingHealthIs1000()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.Health(), 1000);
    }

    [Test]
    public void StartingLevelIs1()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.Level(), 1);
    }
}