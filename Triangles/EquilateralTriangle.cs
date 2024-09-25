using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triangles
{
    internal class EquilateralTriangle : Triangle, IHaveHeight
    {
        double a;

        public double A
        {
            get => a;
            set => a =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }

        //			Constructors:
        public EquilateralTriangle(double a)
        {
            A = a;
        }
        public double GetHeight() => (A * Math.Sqrt(3)) / 2;
        public override double GetArea() => (Math.Sqrt(3) * Math.Pow(A, 2)) / 4;
        public override double GetPerimeter() => A * 3;

        public override void Info()
        {
            Console.WriteLine(this.GetType() + ":");
            Console.WriteLine($"Сторона а: {A}");
            Console.WriteLine($"Сторона в: {A}");
            Console.WriteLine($"Сторона с: {A}");
            Console.WriteLine($"Высота: {GetHeight()}");
            base.Info();
        }
    }
}

