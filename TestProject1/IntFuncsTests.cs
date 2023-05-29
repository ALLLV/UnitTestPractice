using ConsoleApp.IntFuncs;

namespace TestProject1;

[TestClass]
public class IntFuncsTests
{
    [TestMethod]
    public void Sum_3Plus2_Returned5()
    {
        double expected = 5;

        double result = IntFuncs.Sum(3, 2);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Div_3Minus1_Returned2()
    {
        int expected = 2;

        double result = IntFuncs.Div(3, 1);
        Assert.AreEqual(expected, result);
    }
}