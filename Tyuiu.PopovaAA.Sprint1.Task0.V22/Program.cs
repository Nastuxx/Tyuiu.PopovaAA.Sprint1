using Tyuiu.PopovaAA.Sprint1.Task0.V22.Lib;

namespace Tyuiu.PopovaAA.Sprint1.Task0.V22
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #1 | Выполнила Попова А.А. | РППб-24-1";
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("* Спринт #1                                                                 *");
                Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
                Console.WriteLine("* Задание #0                                                                *");
                Console.WriteLine("* Вариант #22                                                               *");
                Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                  *");
                Console.WriteLine("* Написать программу, которая вычисляет выражение 6*2-(5-3) и печатает      *");
                Console.WriteLine("* результат на экране.                                                      *");
                Console.WriteLine("*                                                                           *");
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("* 6 * 2 - (5 - 3)                                                           *");
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
                Console.WriteLine("*****************************************************************************");

                Console.WriteLine(ds.Calculate());

                Console.ReadLine();
            }
        }
    }

    

