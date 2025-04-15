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
}