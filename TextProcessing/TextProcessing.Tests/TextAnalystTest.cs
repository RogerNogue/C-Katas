using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextProcessing;

namespace TextProcessing.Tests;

/*
 * analyst can count the words in a text
 * analyst finds the top 10 most frequent words. Ordered by occurrence but if same amount of occurrences, no order.
 * analyst is not case sensitive
 * Once done, there is a second challenge.
 */

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