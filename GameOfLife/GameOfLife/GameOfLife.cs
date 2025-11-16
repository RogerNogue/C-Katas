namespace GameOfLife;

public class GameOfLife
{
    private World world = new();
    public void AddCell(Cell cell)
    {
        world.Add(cell);
    }

    public bool IsAlive(Cell cell)
    {
        return world.IsAlive(cell);
    }

    public void PassTurn()
    {
        world.PassTurn();
    }
}

public class World
{
    List<Cell> cells = new();
    public void Add(Cell cell)
    {
        cells.Add(cell);
        //log contents of cells
        Console.WriteLine("Cells in world:");
        foreach (var c in cells)
        {            Console.WriteLine($"Cell at ({c.X}, {c.Y})");
        }
    }

    public void PassTurn()
    {
        List<Cell> survivors = new List<Cell>();
        foreach (var cell in cells)
        {
            if (NumberOfNeighbors(cell) is 2 or 3)
            {
                survivors.Add(cell);
            }
        }

        cells = survivors;
    }

    private uint NumberOfNeighbors(Cell cell)
    {
        uint neighborCount = 0;
        foreach (var currentCell in cells)
        {
            if (cell.IsNeighbor(currentCell))
            {
                neighborCount++;
            }
        }
        return neighborCount;
    }

    public bool IsAlive(Cell cell)
    {
        return cells.Contains(cell);
    }
}

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
        return Math.Abs((int)(X - cell.X)) <= 1 && Math.Abs((int)(Y - cell.Y)) <= 1;
    }

    public static Cell Origin()
    {
        return new Cell(0, 0);
    }
}