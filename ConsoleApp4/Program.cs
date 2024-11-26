using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{/// <summary>
/// Задача 4. Определить статический метод int Seconds (int h, int m, int s), 
/// который принимает три целых аргумента (часы h, минуты m и секунды s) и возвращает количество секунд, 
/// прошедших с начала дня. Используя этот метод, вычислить количество секунд, прошедших с начала дня при:
///а) 0 ч 40 мин 20 с;
///б) 3 ч 10 мин 50 с.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int h = Input("h=");
            int m = Input("m=");
            int s = Input("s=");
            int sec = Seconds(h, m, s);
            Output(sec);
            Console.ReadLine();

        }
        static int Seconds(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int min)
        {
            Console.WriteLine(min);
        }
    }
}
