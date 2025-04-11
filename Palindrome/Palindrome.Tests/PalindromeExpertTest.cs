using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests;

[TestClass]
[TestSubject(typeof(PalindromeExpert))]
public class PalindromeExpertTest
{

    [TestMethod]
    public void PalindromeExpertCanBeInstantiated()
    {
        PalindromeExpert sut = new PalindromeExpert();
    }

    [TestMethod]
    public void PalindromeOfa()
    {
        PalindromeExpert sut = new PalindromeExpert();
        
        Assert.AreEqual(sut.IsPalindrome("a"), true);
    }
}