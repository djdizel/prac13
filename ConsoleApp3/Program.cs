using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
 /// Задача 3. Найти s=min(a, b) + min(c, d), используя вспомогательные функции 
 /// (ввода аргументов, нахождения минимальной величины, вывода результата).
 /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");
            int min = Min(a, b);
            int min2 = Min(c, d);
            Output(min, min2);
            Console.ReadLine();
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static void Output(int min, int min2)
        {
            Console.WriteLine($"s = {min+min2}");
        }
    }
}
