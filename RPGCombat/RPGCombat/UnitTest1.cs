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
    
    [Test]
    public void StartsAlive()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.IsAlive(), true);
    }
    
    [Test]
    public void Deal100Damage()
    {
        Character sut = new Character();

        sut.Harm(100);
        
        Assert.AreEqual(sut.Health(), 900);
    }
}