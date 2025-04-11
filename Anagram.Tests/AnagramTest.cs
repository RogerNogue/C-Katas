using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Anagram.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class AnagramTest
{

    [TestMethod]
    public void AnagramCanBeInstantiated()
    {
        Anagram sut = new Anagram();
    }

    [TestMethod]
    public void AnagramGeneratesdo()
    {
        Anagram sut = new Anagram();

        List<string> anagrams = sut.Generate();
        
        Assert(anagrams[0] == "do");
    }
}