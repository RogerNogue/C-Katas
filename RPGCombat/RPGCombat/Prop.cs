namespace RPGCombat;

public class Prop
{
    public int Health { get; set; }
    public Position Position { get; private set; }
    public bool IsDestroyed => Health <= 0;

    private Prop(int health, Position position)
    {
        Health = health;
    }

    public static Prop Aprop(int health)
    {
        return new Prop(health, new Position(0, 0));
    }
}