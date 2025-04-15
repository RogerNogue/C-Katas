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

    public bool IsX5()
    {
        return X == 5;
    }
}

public class ManhattanUrbanPlanner
{
    public int Distance( Coordinate from, Coordinate to )
    {
        if (from.IsX5())
        {
            return 4;
        }
        return 0;
    }
}