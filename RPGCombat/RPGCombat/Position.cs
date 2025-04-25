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

    public int DistanceTo(Position otherPosition)
    {
        return Math.Abs(X - otherPosition.X) + Math.Abs(Y - otherPosition.Y);
    }
}