namespace RPGCombat;

public class Tests
{
    [Test]
    public void HealthStartsAt1000()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.Health(), 1000);
    }
}