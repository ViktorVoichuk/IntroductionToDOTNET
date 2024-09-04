//#define OTPUT_TO_SKREEN
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
#if OTPUT_TO_SKREEN
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

            //Для того чтобы свернуть часть кода его нужно поместить в регион
            #region CodeSnippet
            ////Задаем положение окна на экране
            //Console.WindowLeft = 10;
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10); 
            #endregion

            //задаем размер буфера консоли
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight; 
#endif

            Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();//читает строку с клавиатуры до нажатия enter и возвращает прочитанную строку
            //Console.WriteLine(first_name);

            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a);
            /*
             * Класс Convert представляет собой набор статических методов для преобразования типов.
             * Этот класс используется как правило в том случае когда другие преобразования не работают.
             * */

            //              Операции над строками:
            Console.WriteLine(last_name + " " + first_name + " " + age + " years");//Конкатенация строк

            //Кроме конкатенации строк С# поддерживает форматирование строк:
            Console.WriteLine(String.Format("{0} {1} {2} years", last_name, first_name, age));

            //Интерполяция строк:
            Console.WriteLine($"{last_name} {first_name} {age} years");//Интерполяция - изменение, искажение.


        }
    }
}
