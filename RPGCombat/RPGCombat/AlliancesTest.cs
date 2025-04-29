using static RPGCombat.Character;

namespace RPGCombat;

public class AlliancesTest
{
    [Test]
    public void NewPlayerBelongsToNoFaction()
    {
        Character sut = ACharacter;
        
        Assert.IsFalse(sut.BelongsToAnyFaction());
    }

    [Test]
    public void NewCharacterCanJoinAlliance()
    {
        Character sut = ACharacter;
        
        sut.JoinFaction("Alliance");
        
        Assert.IsTrue(sut.BelongsTo("Alliance"), "Alliance");
    }

    [Test]
    public void NewCharacterCanJoinHorde()
    {
        Character sut = ACharacter;
        
        sut.JoinFaction("Horde");
        
        Assert.IsTrue(sut.BelongsTo("Horde"), "Horde");
    }

    [Test]
    public void NewCharacterCanJoinAllianceAndHorde()
    {
        Character sut = ACharacter;
        
        sut.JoinFaction("Horde");
        sut.JoinFaction("Alliance");
        
        Assert.IsTrue(sut.BelongsTo("Alliance"));
        Assert.IsTrue(sut.BelongsTo("Horde"));
    }

    [Test]
    public void CharacterCanLeaveHorde()
    {
        Character sut = ACharacter;
        
        sut.JoinFaction("Horde");
        sut.LeaveFaction("Horde");
        
        Assert.IsFalse(sut.BelongsToAnyFaction());
    }

    [Test]
    public void NewCharactersAreNotAllies()
    {
        Character sut = ACharacter;
        
        Assert.IsFalse(sut.IsAllyOf(ACharacter));
    }
    
    [Test]
    public void CharactersWhoJoinedTheSameFactionAreAllies()
    {
        Character sut = ACharacter;
        Character other = ACharacter;
        
        sut.JoinFaction("Alliance");
        other.JoinFaction("Alliance");
        
        Assert.IsTrue(sut.IsAllyOf(other));
    }
}