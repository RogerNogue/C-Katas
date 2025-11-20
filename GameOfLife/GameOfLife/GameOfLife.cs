namespace GameOfLife;

public class GameOfLife
{
    List<Cell> cells = new();
    public void AddCell(Cell cell)
    {
        cells.Add(cell);
    }

    public void PassTurn()
    {
        List<Cell> survivors = new List<Cell>();
        foreach (var cell in cells)
        {
            AddNewBornsAround(cell, survivors);
            if (NumberOfNeighbors(cell) is 2 or 3)
            {
                survivors.Add(cell);
            }
        }

        cells = survivors;
    }

    private void AddNewBornsAround(Cell cell, List<Cell> survivors)
    {
        List<Cell> potentialNewBorns = FindEmptyNeighborLocations(cell);
        foreach (var potentialNewBorn in potentialNewBorns)
        {
            if (NumberOfNeighbors(potentialNewBorn) == 3)
            {
                survivors.Add(potentialNewBorn);
            }
        }
    }

    public uint NumberOfNeighbors(Cell cell)
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
}