using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выражение: ");
            string expression = Console.ReadLine();
            
            String[] tokens = expression.Split('+', '-', '*', '/');// split разделяет по операндам, и возвращает строке без знаков которые принимает 
            //for (int i = 0; i < tokens.Length; i++)
            //{
            //    Console.Write(tokens[i] + "\t");
            //}
            //Console.WriteLine();
            double a = Convert.ToDouble(tokens[0]);
            double b = Convert.ToDouble(tokens[1]);
            Console.Write(expression + " = ");
            //Метод Contains класса string определяет, содержит ли строка указанный символ или подстроку
            if (expression.Contains("+")) Console.WriteLine(a + b);
            else if (expression.Contains("-")) Console.WriteLine(a - b);
            else if (expression.Contains("*")) Console.WriteLine(a * b);
            else if (expression.Contains("/")) Console.WriteLine(a / b);
            else Console.WriteLine("No operation");
        }
    }
}
