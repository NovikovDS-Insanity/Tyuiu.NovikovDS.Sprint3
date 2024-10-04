using Tyuiu.NovikovDS.Sprint3.Task1.V6.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task1.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 1, y = 1, k = 4;
        var res = ds.GetSumSeries(k, x, y);
        Assert.AreEqual(4.207, res);
    }
}
