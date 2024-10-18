using Tyuiu.PopovaAA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.PopovaAA.Sprint1.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила Попова А.А. | РППб-24-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                   *");
            Console.WriteLine("* Задание #3                                                                *");
            Console.WriteLine("* Вариант #9                                                                *");
            Console.WriteLine("* Выполнила: Попова Анастасия Алексеевна | РППб-24-1                        *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу пересчета величины временного интервала, заданного     *");
            Console.WriteLine("* в минутах, в величину, выраженную в часах и минутах. Ответ округлите до   *");
            Console.WriteLine("* 3 знаков после запятой.                                                   *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int k, x, y;
            


            Console.WriteLine("Введите исходное значение в минутах: ");
            k = Convert.ToInt32(Console.ReadLine());
            x = k / 60;
            y = k % 60;
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Переведённое время: " + ds.ConvertMinutesToHours(x) + " часа " + ds.ConvertMinutesToHours(y) + " минут ");



        }
    }
}
