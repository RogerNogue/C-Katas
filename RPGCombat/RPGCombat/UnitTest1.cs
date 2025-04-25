namespace RPGCombat;

using static RPGCombat.Character;
public class Tests
{
    [Test]
    public void StartingHealthIs1000()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.Health, 1000);
    }

    [Test]
    public void StartingLevelIs1()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.Level, 1);
    }
    
    [Test]
    public void StartsAlive()
    {
        Character sut = new Character();
        
        Assert.AreEqual(sut.Alive(), true);
    }
    
    [Test]
    public void Deal100Damage()
    {
        Character sut = new Character();

        OtherCharacter.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 900);
    }
    
    [Test]
    public void HealthGoesNoLowerThan0()
    {
        Character sut = new Character();

        OtherCharacter.Harm(sut, 10000);
        
        Assert.AreEqual(sut.Health, 0);
    }
    
    [Test]
    public void IsNotAliveWhenHealthIsZero()
    {
        Character sut = new Character();

        OtherCharacter.Harm(sut, 1000);
        
        Assert.AreEqual(sut.Alive(), false);
    }
    
    [Test]
    public void HealIncreasesHealth()
    {
        Character sut = new Character();

        OtherCharacter.Harm(sut, 100);
        sut.Heal(sut, 100);
        
        Assert.AreEqual(sut.Health, 1000);
    }
    
    [Test]
    public void HealDoesNotGoAbove1000()
    {
        Character sut = new Character();
        
        sut.Heal(sut, 100);
        
        Assert.AreEqual(sut.Health, 1000);
    }
    
    [Test]
    public void CharacterCanLevelUp()
    {
        Character sut = new Character();
        sut.LevelUp(5);
        
        Assert.AreEqual(sut.Level, 6);
    }
}