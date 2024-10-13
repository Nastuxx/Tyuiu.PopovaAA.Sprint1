using Tyuiu.PopovaAA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.PopovaAA.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                *");
            Console.WriteLine("* Задание #5                                                                *");
            Console.WriteLine("* Вариант #5                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой      *");
            Console.WriteLine("* переменной d первую цифру из дробной части положительного вещественного   *");
            Console.WriteLine("* числа x (так, если x=32.597, то d=5).                                     *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
