namespace GameOfLife;

public class GameOfLife
{
    bool isAlive = true;
    public void AddCell(Cell cell)
    {
        
    }

    public bool IsAlive(Cell cell)
    {
        return isAlive;
    }

    public void PassTurn()
    {
        isAlive = false;
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