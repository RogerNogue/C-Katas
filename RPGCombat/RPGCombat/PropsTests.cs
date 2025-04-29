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
    
    [Test]
    public void PropWith0HealthIsDestroyed()
    {
        Prop sut = Aprop(2000);
        
        ACharacter.Harm(sut, 2000);
        
        Assert.IsTrue(sut.IsDestroyed);
    }
}