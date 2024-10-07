using Tyuiu.PopovaAA.Sprint1.Task3.V9.Lib;
namespace Tyuiu.PopovaAA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 150;
            int x = k/60;
            double wait = 2;
            int y = k % 60;
            double wait2 = 30;
            var res = ds.ConvertMinutesToHours(x+y);
            Assert.AreEqual(wait+wait2,res);
        }
    }
}