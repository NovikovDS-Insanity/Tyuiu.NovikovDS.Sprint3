using Tyuiu.NovikovDS.Sprint3.Task4.V23.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task4.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = -5, y = 5;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(244.656, res);
    }
}
