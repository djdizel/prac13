using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Задача 5. Определить статический метод int Meters (int k, int m), 
    /// который принимает два целых аргумента (километры k, метры m) и возвращает количество метров. 
    /// Используя этот метод, вычислить количество метров для расстояния:
    ///а) 3 км 40 м;
    ///б) 12 км 540 м.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int k = Input("k=");
            int m = Input("m=");
            int met = Meters(k, m);
            Output(met);
            Console.ReadLine();

        }
        static int Meters(int k, int m)
        {
            return k*1000+m;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int met)
        {
            Console.WriteLine(met);
        }
    }
}