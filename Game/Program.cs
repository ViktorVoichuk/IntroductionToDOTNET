using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            //Генерация случайного числа
            Random rand = new Random();//Создаем объект класса 'random'
            int x = rand.Next(Console.BufferWidth);// возвращает случайное число типа int
            int y = rand.Next(Console.BufferHeight);
            Console.WriteLine($"X = {x}, Y = {y} ");
            Console.SetCursorPosition(x, y);
            char symbol = (char)2;
            ConsoleKey key;
            Console.CursorVisible = false;
            Console.WriteLine(symbol);
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key.ToString());
                switch (key)
                {
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.UpArrow: y--; break;
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.DownArrow: y++; break;
                    case ConsoleKey.A: x-=2; break;
                    case ConsoleKey.LeftArrow: x -= 2; break;
                    case ConsoleKey.D: x+=2; break;
                    case ConsoleKey.RightArrow: x += 2; break;
                }
                if(y<0) y = Console.BufferHeight - 1;
                if(x<0) x = Console.BufferWidth - 1;
                if(y>Console.BufferHeight - 1) y = 0;
                if(x>Console.BufferWidth - 1) x = 0;
                Console.Clear();
                Console.WriteLine($"X = {x}, Y = {y} ");
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            } while (key != ConsoleKey.Escape);
        }
    }
}
