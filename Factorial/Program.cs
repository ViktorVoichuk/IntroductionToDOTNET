using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int value = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = 0; i < value; i++)
            {
                factorial *= i + 1;
            }
            Console.WriteLine("Факториал числа " + value + " = " + factorial);

        }
    }
}
