using Tyuiu.PopovaAA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.PopovaAA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int d;
            double x = 32.597;
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}