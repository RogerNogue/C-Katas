using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class AnagramTest
{

    [TestMethod]
    public void AnagramCanBeInstantiated()
    {
        Anagram anagram = new Anagram();
    }
}