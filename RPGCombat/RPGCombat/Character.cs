namespace RPGCombat;

public class Character
{
    private int health;

    public Character()
    {
        health = 1000;
    }
    
    public int Health()
    {
        return health;
    }

    public int Level()
    {
        return 1;
    }

    public bool IsAlive()
    {
        return true;
    }

    public void Harm(int damage)
    {
        health -= damage;
    }
}