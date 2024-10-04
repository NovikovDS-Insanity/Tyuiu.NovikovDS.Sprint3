using Tyuiu.NovikovDS.Sprint3.Task0.V3.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task0.V3.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 1, y = 2;
        var res = ds.GetSumSeries(x, y);
        Assert.AreEqual(0.438, res);
    }
}
