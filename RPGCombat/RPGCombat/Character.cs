namespace RPGCombat;

public class Character
{
    private int health;
    private readonly int maxHealth = 1000;

    public Character()
    {
        health = maxHealth;
    }
    
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

    public void Harm(int damage)
    {
        health -= int.Min(damage, health);
    }

    public void Heal(int amount)
    {
        health = int.Min(maxHealth, health + amount);
    }
}