using Tyuiu.PopovaAA.Sprint1.Task4.V4.Lib;
namespace Tyuiu.PopovaAA.Sprint1.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Class Math                                                          *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #4                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране. Ответ округлите  *");
            Console.WriteLine("* до 3 знаков после запятой.                                                *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("(1+x*y)/|x+2| = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
