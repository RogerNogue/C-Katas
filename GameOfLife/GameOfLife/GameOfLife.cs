namespace GameOfLife;

public class GameOfLife
{
    bool isAlive = true;
    private World world = new World();
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
        isAlive = false;
    }
}

public class World
{
    List<Cell> cells = new List<Cell>();
    public void Add(Cell cell)
    {
        cells.Add(cell);
    }

    public void PassTurn()
    {
        if (cells.Count <= 1)
        {
            cells.Clear();
        }
    }

    public bool IsAlive(Cell cell)
    {
        return cells.Count > 1;
    }
}

public class Cell
{
    public uint X, Y;
    public Cell(uint x, uint y)
    {
        X = x;
        Y = y;
    }
    
}