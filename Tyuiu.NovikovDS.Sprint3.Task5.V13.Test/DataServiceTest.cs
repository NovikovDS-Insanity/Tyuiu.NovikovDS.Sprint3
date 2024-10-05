using Tyuiu.NovikovDS.Sprint3.Task5.V13.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task5.V13.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 5, a1 = 1, b1 = 1, a2 = 3, b2 = 12;
        var res = ds.GetSumSumSeries(x, a1, b1, a2, b2);
        Assert.AreEqual(118.212, res);
    }
}
