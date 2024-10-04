using Tyuiu.NovikovDS.Sprint3.Task2.V16.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task2.V16.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 1, y = 5, k = 2;
        var res = ds.GetMultiplySeries(k, x, y);
        Assert.AreEqual(14400, res);
    }
}
