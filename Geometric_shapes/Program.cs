using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Квадрат
            Console.Write("Введите сторону: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //треугольник1
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //треугольник2
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //треугольник3
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j < i)
                    {
                        Console.Write(" ");
                    }
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //треугольник4
            for (int i = 0; i < size; i++)
            {
                for (int j = size; j > 0; j--)
                {
                    if (j > i + 1)
                    {
                        Console.Write(" ");
                    }
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ромб
            int bufsize = size;
            if (bufsize % 2 != 0)
            {
                bufsize += 1;
            }
            for (int i = 0; i < bufsize; i++)
            {
                for (int j = 0; j < bufsize; ++j)
                {

                    if (j == bufsize / 2 - 1 - i || j == bufsize - 1 - (i - bufsize / 2))
                    {
                        Console.Write("/");
                    }
                    else if (j == bufsize / 2 + i || i == bufsize / 2 + j)
                    {
                        Console.Write("\\");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //квадрат +-
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0) Console.Write("+ ");
                        else Console.Write("- ");
                    }
                    else
                    {
                        if (j % 2 == 0) Console.Write("- ");
                        else Console.Write("+ ");
                    }
                }
                Console.WriteLine();
            }

            //шахматная доска
            Console.Write("Введите размар клетки: ");
            int cell = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите символ: ");
            char sim = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (i % 2 == 0)
                        {
                            for (int c = 0; c < cell; c++)
                            {
                                Console.Write(sim + " ");
                            }
                            for (int x = 0; x < cell; x++)
                            {
                                Console.Write("  ");
                            }
                        }
                        else
                        {
                            for (int c = 0; c < cell; c++)
                            {
                                Console.Write("  ");
                            }
                            for (int x = 0; x < cell; x++)
                            {
                                Console.Write(sim + " ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }

            //шахматная доска цвет
            Console.Write("Введите размар клетки: ");
            int cell1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < cell1; j++)
                {
                    for (int k = 0; k < cell1; k++)
                    {
                        if (i % 2 == 0)
                        {
                            for (int c = 0; c < cell1; c++)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("* ");
                            }
                            for (int x = 0; x < cell1; x++)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("  ");
                            }
                        }
                        else
                        {
                            for (int c = 0; c < cell1; c++)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("  ");
                            }
                            for (int x = 0; x < cell1; x++)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("* ");
                            }
                        }
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}
