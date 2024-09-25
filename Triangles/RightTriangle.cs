using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class RightTriangle : Triangle, IHaveHeight
    {
        double a;
        double b;
        double c;

        public double A
        {
            get => a;
            set => a =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }
        public double B
        {
            get => b;
            set => b =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }

        //			Constructors:
        public RightTriangle(double a, double b)
        {
            A = a;
            B = b;
            c = Math.Sqrt(A * A + B * B);
        }
        public double GetHeight() => (A*B)/c;
        public override double GetArea() => (A*B)/2;
        public override double GetPerimeter() => A+B+c;

        public override void Info()
        {
            Console.WriteLine(this.GetType() + ":");
            Console.WriteLine($"Сторона а: {A}");
            Console.WriteLine($"Сторона в: {B}");
            Console.WriteLine($"Сторона с: {c}");
            Console.WriteLine($"Высота: {GetHeight()}");
            base.Info();
        }
    }
}
