namespace RPGCombat;

public class AlliancesTest
{
    [Test]
    public void NewPlayerBelongsToNoFaction()
    {
        Character sut = Character.ACharacter;
        
        Assert.IsFalse(sut.BelongsToAnyFaction());
    }

    [Test]
    public void NewCharacterCanJoinAlliance()
    {
        Character sut = Character.ACharacter;
        
        sut.JoinFaction("Alliance");
        
        Assert.IsTrue(sut.BelongsTo("Alliance"), "Alliance");
    }

    [Test]
    public void NewCharacterCanJoinHorde()
    {
        Character sut = Character.ACharacter;
        
        sut.JoinFaction("Horde");
        
        Assert.IsTrue(sut.BelongsTo("Horde"), "Horde");
    }

    [Test]
    public void NewCharacterCanJoinAllianceAndHorde()
    {
        Character sut = Character.ACharacter;
        
        sut.JoinFaction("Horde");
        sut.JoinFaction("Alliance");
        
        Assert.IsTrue(sut.BelongsTo("Alliance"));
        Assert.IsTrue(sut.BelongsTo("Horde"));
    }

    [Test]
    public void CharacterCanLeaveHorde()
    {
        Character sut = Character.ACharacter;
        
        sut.JoinFaction("Horde");
        sut.LeaveFaction("Horde");
        
        Assert.IsFalse(sut.BelongsToAnyFaction());
    }

    [Test]
    public void NewCharactersAreNotAllies()
    {
        Character sut = Character.ACharacter;
        
        Assert.IsFalse(sut.IsAllyOf(Character.ACharacter));
    }
}