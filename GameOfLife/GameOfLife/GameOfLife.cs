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
        foreach (Cell currentCell in cells)
        {
            if ( cell.IsNeighbor(currentCell))
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

    public List<Cell> FindNeighborLocations(Cell cell)
    {
        List<Cell> neighbors = new List<Cell>();
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int newCellX = (int)cell.X + i;
                int newCellY = (int)cell.Y + j;
                if (newCellX < 0 || newCellY < 0) continue;
                if (newCellX == cell.X && newCellY == cell.Y) continue;
                neighbors.Add(new Cell((uint)newCellX, (uint)newCellY));
            }
        }
        
        return neighbors;
    }

    public List<Cell> FindEmptyNeighborLocations(Cell cell)
    {
        List<Cell> neighborLocations = FindNeighborLocations(cell);
        List<Cell> emptyLocations = new List<Cell>();
        foreach (var neighborLocation in neighborLocations)
        {
            if(cells.Contains(neighborLocation))
            {
                continue;
            }
            emptyLocations.Add(neighborLocation);
        }

        return emptyLocations;
    }

    public List<Cell> FindAliveNeighbors(Cell origin)
    {
        return new List<Cell>();
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