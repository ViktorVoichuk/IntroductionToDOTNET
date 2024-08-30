using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Introduction to .NET"; //задает название консоли
            //Console.Write("Hello .NET"); //Выводит строку в консоль
            Console.WriteLine("Hello .NET"); // Вывод в консоль и переходит на новую строку

            Console.BackgroundColor = ConsoleColor.Blue;    //цвет фона
            Console.ForegroundColor = ConsoleColor.Black;     //цвет текста

            //Console.CursorLeft = 24;       //координата курсора по оси Х
            //Console.CursorTop = 5;        //координата курсора по оси У
            Console.SetCursorPosition(15, 5);   // задаются Х и У координаты
            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor();   //применяет стандартную цветовую схему

            //Console.WindowWidth = 64;   //задаем размеры окна
            //Console.WindowHeight = 16;  //задаем размеры окна
            Console.SetWindowSize(64, 16);

            ////Задаем положение окна на экране
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10);

            //задаем размер буфера консоли
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }
    }
}
