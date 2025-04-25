namespace RPGCombat;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static bool operator ==(Position p1, Position p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(Position p1, Position p2)
    {
        return ! (p1 == p2);
    }
}    
    

public class Character
{
    public int Health { get; private set; }
    private readonly int maxHealth = 1000;
    public int Level { get; private set; } = 1;
    public bool Alive() => Health > 0;
    public int Range;
    public Position Position { get; private set; }

    private Character(int range)
    {
        Range = range;
        Health = maxHealth;
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
}