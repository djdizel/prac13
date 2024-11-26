using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
 /// Задача 1. Найти минимальную величину из двух целых переменных a, b, 
 /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
 /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int min = Min(a, b);
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
        static void Output(int min)
        {
            Console.WriteLine(min);
        }
        }
    }

