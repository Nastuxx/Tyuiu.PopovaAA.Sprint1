using Tyuiu.PopovaAA.Sprint1.Task7.V11.Lib;
namespace Tyuiu.PopovaAA.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 1;
            double wait = -3.776;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
             
        }
    }
}