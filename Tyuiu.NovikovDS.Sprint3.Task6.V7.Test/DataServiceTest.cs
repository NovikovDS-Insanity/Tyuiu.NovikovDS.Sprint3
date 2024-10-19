using Tyuiu.NovikovDS.Sprint3.Task6.V7.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task6.V7.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int a1 = 2, a2 = 3;
        var res = ds.GetSumTheDivisors(a1, a2);
        Assert.AreEqual(7, res);
    }
}
