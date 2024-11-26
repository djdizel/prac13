using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
 /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c 
 /// с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
        class Program
        {
            static void Main(string[] args)
            {
                int a = Input("a=");
                int b = Input("b=");
                int c = Input("c=");
                int min = Min(Min(a, b),c);
                //int min2 = Minn(b,c);
                //int min3 = Minnn(min,min2);
                Output(min);
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
        //static int Minn(int b, int c)
        //{
        //    return c < b ? c : b;
        //}
        //static int Minnn(int d, int v)
        //{
        //    return d < v ? d : v;
        //}
        static void Output(int min)
        {
            Console.WriteLine(min);
        }
    }
}
