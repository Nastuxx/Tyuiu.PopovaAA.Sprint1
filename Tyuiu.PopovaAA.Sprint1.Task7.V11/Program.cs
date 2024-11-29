using Tyuiu.PopovaAA.Sprint1.Task7.V11.Lib;
namespace Tyuiu.PopovaAA.Sprint1.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #11                                                               *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по         *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до 3   *");
            Console.WriteLine("* знаков после запятой.                                                     *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("*                   x                                                       *");
            Console.WriteLine("*           (lnsinx)             1/2                                        *");
            Console.WriteLine("*     z = ------------  + (y- |x|   )                                       *");
            Console.WriteLine("*                 2                                                         *");
            Console.WriteLine("*           ln(1+x )                                                        *");


            double x,y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
