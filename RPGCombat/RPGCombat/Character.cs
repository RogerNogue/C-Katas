namespace RPGCombat;

/*tasks:
 * Characters can be allies.
 * allies cannot deal damage to one another.
 * allies can heal one another.
 */

public class Character
{
    public int Health { get; private set; }
    private readonly int maxHealth = 1000;
    public int Level { get; private set; } = 1;
    public bool Alive() => Health > 0;
    public int Range;
    private Affiliations affiliations;
    public Position Position { get; private set; }

    private Character(int range)
    {
        Range = range;
        Health = maxHealth;
        Position = new Position(0, 0);
        affiliations = new Affiliations();
    }

    public static Character MeleeCharacter()
    {
        return new Character(2);
    }
    
    public static Character RangedCharacter()
    {
        return new Character(20);
    }

    public static Character ACharacter => MeleeCharacter();

    public void LevelUp(int levels)
    {
        Level += levels;
    }

    public void Harm(Character target, int damage)
    {
        if (this == target)
            throw new InvalidOperationException("A Character cannot Deal Damage to itself.");

        if (this.Position.DistanceTo(target.Position) > Range)
            return;
        
        int dealtDamage = damage;
        if ( target.Level >= Level + 5 )
            dealtDamage = (int)(dealtDamage * 0.5f);
        if( Level >= target.Level + 5 )
            dealtDamage = (int)(dealtDamage * 1.5f);
        target.Health -= int.Min(dealtDamage, Health);
    }
    
    public void Heal(Character target, int amount)
    {
        if (!target.Alive())
            throw new InvalidOperationException("Dead characters cannot be healed.");
        if (this != target)
            throw new InvalidOperationException("A Character can only heal itself");
        target.Health = int.Min(maxHealth, target.Health + amount);
    }

    public void Move(Position position)
    {
        Position = position;
    }

    public void JoinFaction(string faction)
    {
        affiliations.Join(faction);
    }
    
    public void LeaveFaction(string faction)
    {
        affiliations.Leave(faction);
    }

    public bool BelongsTo(string faction)
    {
        return affiliations.BelongsTo(faction);
    }
    
    public bool BelongsToAnyFaction()
    {
        return affiliations.BelongsToAny();
    }

    public bool IsAllyOf(Character aCharacter)
    {
        return false;
    }
}