namespace RPGCombat;

public class Character
{
    private int health;
    private readonly int maxHealth = 1000;

    public Character()
    {
        health = maxHealth;
    }

    public static Character OtherCharacter => new();

    public int Health()
    {
        return health;
    }

    public int Level()
    {
        return 1;
    }

    public bool Alive()
    {
        return health > 0;
    }

    public void Harm(Character target, int damage)
    {
        if (this == target)
            throw new InvalidOperationException("A Character cannot Deal Damage to itself.");
        target.health -= int.Min(damage, health);
    }
    
    public void Heal(Character target, int amount)
    {
        if (!target.Alive())
            throw new InvalidOperationException("Dead characters cannot be healed.");
        if (this != target)
            throw new InvalidOperationException("A Character can only heal itself");
        target.health = int.Min(maxHealth, target.health + amount);
    }
}