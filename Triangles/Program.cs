using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle[] shapes = new Triangle[]
            {
                new EquilateralTriangle(4),
                new RightTriangle(4,5),
                new ScaleneTriangle(6,7,8)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Info();
            }
        }
    }
}
