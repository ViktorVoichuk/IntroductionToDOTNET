//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORS_CHECK
            Fraction A = new Fraction();
            A.Print();
            Console.WriteLine(A);

            Fraction B = new Fraction(5);
            B.Print();
            Console.WriteLine(B);

            Fraction C = new Fraction(1, 2);
            C.Print();
            Console.WriteLine(C);

            Fraction D = new Fraction(2, 3, 4);
            D.Print();
            Console.WriteLine(D.ToString());
            Console.WriteLine(D.GetType()); 
#endif
            Fraction A = new Fraction(2, 3, 4);
            Fraction B = new Fraction(3, 4, 5);
            Fraction C = new Fraction(A * B);
            Fraction D = new Fraction(A / B);
            Fraction E = new Fraction(A + B);
            Fraction F = new Fraction(B - A);
            A.Print();
            B.Print();
            C.Print();
            D.Print();
            E.Print();
            F.Print();
            F++;
            F.Print();
            F--;
            F.Print();
            Console.WriteLine(F == E);
            Console.WriteLine(F != E);
            Console.WriteLine(F > E);
            Console.WriteLine(F < E);
            Console.WriteLine(F >= E);
            Console.WriteLine(F <= E);

        }
    }
}
