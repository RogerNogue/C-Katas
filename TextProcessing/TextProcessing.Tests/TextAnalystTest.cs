using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextProcessing;

namespace TextProcessing.Tests;

[TestClass]
[TestSubject(typeof(TextAnalyst))]
public class TextAnalystTest
{

    [TestMethod]
    public void TextAnalystCanBeInstantiated()
    {
        TextAnalyst sut = new TextAnalyst();
        
        Assert.IsTrue(true);
    }
    
    [TestMethod]
    public void HelloIs1Word()
    {
        TextAnalyst sut = new TextAnalyst();
        
        Assert.AreEqual(1, sut.CountWords("Hello"));
    }
}