namespace RPGCombat;

using static RPGCombat.Character;
public class CharacterTests
{
    [Test]
    public void StartingHealthIs1000()
    {
        Character sut = ACharacter;
        
        Assert.AreEqual(sut.Health, 1000);
    }

    [Test]
    public void StartingLevelIs1()
    {
        Character sut = ACharacter;
        
        Assert.AreEqual(sut.Level, 1);
    }
    
    [Test]
    public void StartsAlive()
    {
        Character sut = ACharacter;
        
        Assert.AreEqual(sut.Alive(), true);
    }
    
    [Test]
    public void Deal100Damage()
    {
        Character sut = ACharacter;

        ACharacter.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 900);
    }
    
    [Test]
    public void HealthGoesNoLowerThan0()
    {
        Character sut = ACharacter;

        ACharacter.Harm(sut, 10000);
        
        Assert.AreEqual(sut.Health, 0);
    }
    
    [Test]
    public void IsNotAliveWhenHealthIsZero()
    {
        Character sut = ACharacter;

        ACharacter.Harm(sut, 1000);
        
        Assert.AreEqual(sut.Alive(), false);
    }
    
    [Test]
    public void HealIncreasesHealth()
    {
        Character sut = ACharacter;

        ACharacter.Harm(sut, 100);
        sut.Heal(sut, 100);
        
        Assert.AreEqual(sut.Health, 1000);
    }
    
    [Test]
    public void HealDoesNotGoAbove1000()
    {
        Character sut = ACharacter;
        
        sut.Heal(sut, 100);
        
        Assert.AreEqual(sut.Health, 1000);
    }
    
    [Test]
    public void CharacterCanLevelUp()
    {
        Character sut = ACharacter;
        sut.LevelUp(5);
        
        Assert.AreEqual(sut.Level, 6);
    }
    
    [Test]
    public void IfHarmTargetIs5LevelsAbove50percentLessDamage()
    {
        Character sut = ACharacter;
        
        sut.LevelUp(5);
        ACharacter.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 950);
    }
    
    [Test]
    public void IfHarmDealerIs5LevelsAbove50percentMoreDamage()
    {
        Character sut = ACharacter;
        Character other = ACharacter;
        
        other.LevelUp(5);
        other.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 850);
    }

    [Test]
    public void CharacterCanNotHarmItself()
    {
        Character sut = ACharacter;
        
        Assert.Catch<InvalidOperationException>(() => sut.Harm(sut, 100));
    }
    
    [Test]
    public void CharacterCanOnlyHealItself()
    {
        Character sut = ACharacter;
        
        ACharacter.Harm(sut, 100);
        
        Assert.Catch<InvalidOperationException>(() => ACharacter.Heal(sut, 100));
    }
    
    [Test]
    public void OnlyAliveTargetsCanBeHealed()
    {
        Character sut = ACharacter;
        
        ACharacter.Harm(sut, 1000);
        
        Assert.Catch<InvalidOperationException>(() => sut.Heal(sut, 100));
    }
    
    [Test]
    public void CharacterCanMove()
    {
        Character sut = ACharacter;

        sut.Move(new Position(1, 1));
        
        Assert.IsTrue(sut.Position == new Position(1, 1));
    }
    
    [Test]
    public void SamePositionsHave0Distance()
    {
        Position sut = new Position(1, 1);
        
        Assert.IsTrue(sut.DistanceTo(new Position(1, 1)) == 0);
    }
    
    [Test]
    public void DistanceOf5Between2Positions()
    {
        Position sut = new Position(1, 1);
        
        Assert.IsTrue(sut.DistanceTo(new Position(4, 3)) == 5);
    }
    
    [Test]
    public void MeleeInRange3DonesNotDealDamage()
    {
        Character sut = MeleeCharacter();
        
        sut.Move(new Position(3, 2));
        ACharacter.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 1000);
    }
    
    [Test]
    public void RangedAtRange20DealsDamage()
    {
        Character sut = MeleeCharacter();
        Character ranged = RangedCharacter();
        
        sut.Move(new Position(20, 0));
        ranged.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 900);
    }
    
    [Test]
    public void RangedAtRange21DoesNotDealDamage()
    {
        Character sut = MeleeCharacter();
        Character ranged = RangedCharacter();
        
        sut.Move(new Position(21, 0));
        ranged.Harm(sut, 100);
        
        Assert.AreEqual(sut.Health, 1000);
    }
    
    [Test]
    public void NewPlayerBelongsToNoFaction()
    {
        Character sut = ACharacter;
        
        Assert.AreEqual(sut.Faction, "None");
    }
    
    [Test]
    public void NewCharacterCanJoinAlliance()
    {
        Character sut = ACharacter;
        
        sut.JoinFaction("Alliance");
        
        Assert.AreEqual(sut.Faction, "Alliance");
    }
    
    [Test]
    public void NewCharacterCanJoinHorde()
    {
        Character sut = ACharacter;
        
        sut.JoinFaction("Horde");
        
        Assert.AreEqual(sut.Faction, "Horde");
    }
}