namespace GameOfLife;

public readonly struct Cell
{
    public readonly uint X, Y;
    public Cell(uint x, uint y)
    {
        X = x;
        Y = y;
    }

    public bool IsNeighbor(Cell cell)
    {
        bool isNeighbor = false;
        int dx = Math.Abs((int)(X - cell.X));
        int dy = Math.Abs((int)(Y - cell.Y));
        isNeighbor = isNeighbor || dx == 1 && dy == 1;
        isNeighbor = isNeighbor || dx == 1 && dy == 0;
        isNeighbor = isNeighbor || dx == 0 && dy == 1;
        return isNeighbor;
    }

    public static Cell Origin()
    {
        return new Cell(0, 0);
    }
}