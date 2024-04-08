using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentanceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(4, outcome);
    }

    [TestMethod]
    public void Q2_BasicNominalTest() 
    {
        var input = "Forget CVs..Save time . x x";
        var output = LongestSentanceAnswer.Solution(input);

        Assert.AreEqual(2, output);
    }
}
