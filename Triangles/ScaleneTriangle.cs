using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class ScaleneTriangle : Triangle, IHaveHeight
    {
        double a;
        double b;
        double c;
        double p;

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
        public double C
        {
            get => c;
            set => c =
                value < MIN_SIZE ? MIN_SIZE :
                value > MAX_SIZE ? MAX_SIZE :
                value;
        }

        //			Constructors:
        public ScaleneTriangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            p = (A + B + C) / 2;
        }
        public double GetHeight() => (2*GetArea())/A;
        public override double GetArea() => Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        public override double GetPerimeter() => A + B + C;

        public override void Info()
        {
            Console.WriteLine(this.GetType() + ":");
            Console.WriteLine($"Сторона а: {A}");
            Console.WriteLine($"Сторона в: {B}");
            Console.WriteLine($"Сторона с: {C}");
            Console.WriteLine($"Высота: {GetHeight()}");
            base.Info();
        }
    }
}
