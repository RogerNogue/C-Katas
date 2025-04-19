using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextProcessing;

namespace TextProcessing.Tests;

/*
 * [x] analyst can count the words in a text
 * analyst finds the top 10 most frequent words. Ordered by occurrence but if same amount of occurrences, no order. Not case sensitive
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
        
        Assert.AreEqual(1, sut.CountWords("Hello."));
    }

    [TestMethod]
    public void HelloHowAreYouIs4Words()
    {
        TextAnalyst sut = new TextAnalyst();
        
        Assert.AreEqual(4, sut.CountWords("Hello how are you"));
    }

    [TestMethod]
    public void TextOf10Words()
    {
        TextAnalyst sut = new TextAnalyst();
        
        Assert.AreEqual(10, sut.CountWords("This text contains ten words sixth seventh eith ninth tenth"));
    }

    [TestMethod]
    public void Top10WordsIn10WordsText()
    {
        TextAnalyst textAnalyst = new TextAnalyst();
        List<string> sut = textAnalyst.Top10Words("This text contains ten words sixth seventh eighth ninth tenth.");
        
        Assert.AreEqual(10, sut.Count);
        Assert.AreEqual("this", sut[0]);
        Assert.AreEqual("text", sut[1]);
        Assert.AreEqual("contains", sut[2]);
        Assert.AreEqual("ten", sut[3]);
        Assert.AreEqual("words", sut[4]);
        Assert.AreEqual("sixth", sut[5]);
        Assert.AreEqual("seventh", sut[6]);
        Assert.AreEqual("eighth", sut[7]);
        Assert.AreEqual("ninth", sut[8]);
        Assert.AreEqual("tenth", sut[9]);
    }
}