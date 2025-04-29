using static RPGCombat.Prop;
using static RPGCombat.Character;

namespace RPGCombat;

public class PropsTests
{
    [Test]
    public void PropCanBeDamaged()
    {
        Prop sut = Aprop(2000);
        
        ACharacter.Harm(sut, 500);
        
        Assert.AreEqual(sut.Health, 1500);
    }
}