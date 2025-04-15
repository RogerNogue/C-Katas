namespace ManhattanDistance;

public class Coordinate
{
    private int X;
    private int Y;

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int DistanceWith(Coordinate other)
    {
        return ( int.Abs(X - other.X) + int.Abs(Y - other.Y) );
    }
}

public class ManhattanUrbanPlanner
{
    public int Distance( Coordinate from, Coordinate to )
    {
        return from.DistanceWith(to);
    }
}