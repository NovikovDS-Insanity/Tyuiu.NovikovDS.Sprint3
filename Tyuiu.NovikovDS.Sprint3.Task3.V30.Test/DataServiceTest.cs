using Tyuiu.NovikovDS.Sprint3.Task3.V30.Lib;

namespace Tyuiu.NovikovDS.Sprint3.Task3.V30.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        string x = "asdasdas sadaaaasd saadsaaads";
        char y = 'a';
        var res = ds.GetMaxCharCount(x, y);
        Assert.AreEqual(4, res);
    }
}
