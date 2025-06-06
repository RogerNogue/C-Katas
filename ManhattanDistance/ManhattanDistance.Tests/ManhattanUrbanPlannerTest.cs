using JetBrains.Annotations;
using ManhattanDistance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManhattanDistance.Tests;

[TestClass]
[TestSubject(typeof(ManhattanUrbanPlanner))]
public class ManhattanUrbanPlannerTest
{

    [TestMethod]
    public void UrbanPlannerCanBeInstantiated()
    {
        ManhattanUrbanPlanner sut = new ManhattanUrbanPlanner();
        
        Assert.IsNotNull(sut);
    }

    [TestMethod]
    public void DistanceFrom00To00Is0()
    {
        ManhattanUrbanPlanner sut = new ManhattanUrbanPlanner();
        
        Assert.AreEqual(0, sut.Distance(new Coordinate(0, 0), new Coordinate(0, 0)));
    }

    [TestMethod]
    public void DistanceFrom11To11Is0()
    {
        ManhattanUrbanPlanner sut = new ManhattanUrbanPlanner();
        
        Assert.AreEqual(0, sut.Distance(new Coordinate(1, 1), new Coordinate(1, 1)));
    }
    
    [TestMethod]
    public void DistanceFrom54To32Is4()
    {
        ManhattanUrbanPlanner sut = new ManhattanUrbanPlanner();
        
        Assert.AreEqual(4, sut.Distance(new Coordinate(5, 4), new Coordinate(3, 2)));
    }

    [TestMethod]
    public void DistanceFrom11To03Is3()
    {
        ManhattanUrbanPlanner sut = new ManhattanUrbanPlanner();
        
        Assert.AreEqual(3, sut.Distance(new Coordinate(1, 1), new Coordinate(0, 3)));
    }
}