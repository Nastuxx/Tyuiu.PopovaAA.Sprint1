using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PopovaAA.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((double.Log(Math.Pow((Math.Sin(x)), x), 10)) / (double.Log((1 + (Math.Pow(x, 2))), 10)) + (y - Math.Sqrt(Math.Abs(x)))),3);
        }
    }
}
