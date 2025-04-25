namespace RPGCombat;

public class Character
{
    public int Health;
    private readonly int maxHealth = 1000;
    private int level = 1;
    public bool Alive() => Health > 0;

    public Character()
    {
        Health = maxHealth;
    }

    public static Character OtherCharacter => new();

    public int Level()
    {
        return level;
    }

    public void LevelUp(int levels)
    {
        levels += levels;
    }

    public void Harm(Character target, int damage)
    {
        if (this == target)
            throw new InvalidOperationException("A Character cannot Deal Damage to itself.");
        target.Health -= int.Min(damage, Health);
    }
    
    public void Heal(Character target, int amount)
    {
        if (!target.Alive())
            throw new InvalidOperationException("Dead characters cannot be healed.");
        if (this != target)
            throw new InvalidOperationException("A Character can only heal itself");
        target.Health = int.Min(maxHealth, target.Health + amount);
    }
}