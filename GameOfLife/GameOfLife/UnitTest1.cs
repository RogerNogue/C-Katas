namespace GameOfLife;
/*
Any live cell with fewer than two live neighbours dies, as if caused by under-population.
Any live cell with two or three live neighbours lives on to the next generation.
Any live cell with more than three live neighbours dies, as if by overcrowding.
Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

to do the reproduction, I'll split it into smaller steps:
- Count the empty neighbors for each cell
- Find The Living Neighbors of an empty cell
- Whole feature
 */
public class Tests
{
    [Test]
    public void CellIsAlive()
    {
        GameOfLife sut = new GameOfLife();

        sut.AddCell(Cell.Origin());
        
        Assert.True(sut.IsAlive(Cell.Origin()));
    }

    [Test]
    public void LoneCellDiesAfterTurn()
    {
        GameOfLife sut = new GameOfLife();
        
        sut.AddCell(Cell.Origin());
        sut.PassTurn();
        
        Assert.False(sut.IsAlive(Cell.Origin()));
    }

    [Test]
    public void CellWithNeighborsSurvives()
    {
        GameOfLife sut = new GameOfLife();
        
        sut.AddCell(Cell.Origin());
        sut.AddCell(new Cell(1, 0));
        sut.AddCell(new Cell(0, 1));
        sut.PassTurn();
        
        Assert.True(sut.IsAlive(Cell.Origin()));
    }

    [Test]
    public void CellWithNoNeighborsButOtherCellsDoesNotSurvive()
    {
        GameOfLife sut = new GameOfLife();
        
        sut.AddCell(Cell.Origin());
        sut.AddCell(new Cell(2, 0));
        sut.AddCell(new Cell(0, 2));
        sut.PassTurn();
        
        Assert.False(sut.IsAlive(Cell.Origin()));
    }

    [Test]
    public void CellWithOneNeighborDoesNotSurvive()
    {
        GameOfLife sut = new GameOfLife();
        
        sut.AddCell(Cell.Origin());
        sut.AddCell(new Cell(1, 0));
        sut.PassTurn();
        
        Assert.False(sut.IsAlive(Cell.Origin()));
    }

    [Test]
    public void CellsWith3NeighborsSurvive()
    {
        GameOfLife sut = new GameOfLife();
        
        sut.AddCell(Cell.Origin());
        sut.AddCell(new Cell(1, 0));
        sut.AddCell(new Cell(0, 1));
        sut.AddCell(new Cell(1, 1));
        sut.PassTurn();
        
        Assert.True(sut.IsAlive(Cell.Origin()));
    }

    [Test]
    public void CellsWithMoreThan3NeighborsDieFromOvercrowding()
    {
        GameOfLife sut = new GameOfLife();
        
        sut.AddCell(Cell.Origin());
        sut.AddCell(new Cell(1, 1));
        sut.AddCell(new Cell(2, 1));
        sut.AddCell(new Cell(1, 2));
        sut.AddCell(new Cell(2, 2));
        sut.PassTurn();
        
        Assert.False(sut.IsAlive(new Cell(1, 1)));
    }

    [Test]
    public void ACellHas8Neighbors()
    {
        World sut = new World();
        
        sut.Add(new Cell(1, 1));
        
        Assert.True(sut.FindNeighbors(new Cell(1, 1)).Count == 8);
    }

    [Test]
    public void OriginHas3Neighbors()
    {
        World sut = new World();
        
        sut.Add(Cell.Origin());
        
        Assert.True(sut.FindNeighbors(Cell.Origin()).Count == 3);
    }
}