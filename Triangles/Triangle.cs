using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Triangles
{
    abstract class Triangle
    {
        const string line = "----------------------------------------------------------";
        public static readonly int MIN_SIZE = 1;
        public static readonly int MAX_SIZE = 20;

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public virtual void Info()
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
            Console.WriteLine(line);
        }
    }
}
