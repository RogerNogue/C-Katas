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
}