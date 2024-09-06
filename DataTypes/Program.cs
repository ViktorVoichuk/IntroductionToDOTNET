//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimeter1 = "\n----------------------------------------------\n";
        static readonly string delimeter2 = "\n==============================================\n";
        static void Main(string[] args)
        {
            Console.WriteLine("C# DataTypes");

            #region Boolean
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine(Convert.ToBoolean(1));
            //Console.WriteLine(bool.Parse("false")); 
            #endregion

            #region Char
            ////Unicode
            //Console.WriteLine(char.GetNumericValue(char.MinValue));
            //Console.WriteLine(Char.MaxValue); 
            #endregion

#if NUMERIC_TYPES
            Console.Write($"Переменная типа 'short' занимает {sizeof(short)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {short.MinValue} ... {short.MaxValue}");
            Console.Write($"Диапазон принимаемых значений 'ushort': {ushort.MinValue}...{ushort.MaxValue}");
            Console.WriteLine(delimeter1);

            Console.Write($"Переменная типа 'Int16' занимает {sizeof(Int16)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {Int16.MinValue} ... {Int16.MaxValue}");
            Console.Write($"Диапазон принимаемых значений 'UInt16': {UInt16.MinValue}...{UInt16.MaxValue}");
            //Convert.ToInt16();
            Console.WriteLine();
            Console.WriteLine(delimeter2);

            Console.Write($"Переменная типа 'int' занимает {sizeof(int)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {int.MinValue} ... {int.MaxValue}");
            Console.Write($"Диапазон принимаемых значений 'ushort': {uint.MinValue}...{uint.MaxValue}");
            Console.WriteLine(delimeter1);

            Console.Write($"Переменная типа 'Int32' занимает {sizeof(Int32)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {Int32.MinValue} ... {Int32.MaxValue}");
            Console.Write($"Диапазон принимаемых значений 'UInt32': {UInt32.MinValue}...{UInt32.MaxValue}");
            Console.WriteLine(delimeter2);

            Console.Write($"Переменная типа 'long' занимает {sizeof(long)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {long.MinValue} ... {long.MaxValue}");
            Console.Write($"Диапазон принимаемых значений 'ushort': {ulong.MinValue}...{ulong.MaxValue}");
            Console.WriteLine(delimeter1);

            Console.Write($"Переменная типа 'Int64' занимает {sizeof(Int64)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {Int64.MinValue} ... {Int64.MaxValue}");
            Console.Write($"Диапазон принимаемых значений 'UInt16': {UInt64.MinValue}...{UInt64.MaxValue}");
            Console.WriteLine(delimeter2);
            

            //Single precision:

            //float
            Console.Write($"Переменная типа 'float' занимает {sizeof(float)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine(delimeter1);
            Console.Write($"Переменная типа 'Single' занимает {sizeof(Single)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {Single.MinValue} ... {Single.MaxValue}");
            Console.WriteLine(delimeter2);

            //double
            Console.Write($"Переменная типа 'double' занимает {sizeof(double)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine(delimeter1);
            Console.Write($"Переменная типа 'Double' занимает {sizeof(Double)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {Double.MinValue} ... {Double.MaxValue}");
            Console.WriteLine(delimeter2);

            //Decimal
            Console.Write($"Переменная типа 'decimal' занимает {sizeof(decimal)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}");
            Console.WriteLine(delimeter1);
            Console.Write($"Переменная типа 'Decimal' занимает {sizeof(Decimal)} Байта памяти");
            Console.WriteLine($"и принимает значение в диапазоне: {Decimal.MinValue} ... {Decimal.MaxValue}");
            Console.WriteLine(delimeter2);
#endif

#if LITERALS
            Console.WriteLine(123.GetType());//int
            Console.WriteLine(123u.GetType());//uint
            Console.WriteLine(123L.GetType());//long
            Console.WriteLine(123ul.GetType());//ulong
            Console.WriteLine(delimeter1);

            Console.WriteLine(123.4.GetType());//double
            Console.WriteLine(123.4f.GetType());//float
            Console.WriteLine(123.4m.GetType());//decimal
            Console.WriteLine(delimeter1);

            Console.WriteLine('+'.GetType());//char
            Console.WriteLine("Hello".GetType());//string  
#endif

            #region Conversions1
            //Console.WriteLine(((byte)5).GetType().Name);
            //byte a = 2;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a + "\t" + b);
            //a = (byte)b;//Truncation - усечение. Упезается либо дробная часть при записи дробного числа в целочисленную переменную.
            //            //                       либо старшие байты целого числа, при записи его в меньшую целочисленную переменную.
            //Console.WriteLine(a + "\t" + b); 
            #endregion

            try
            {
                int a = int.MaxValue;
                Console.WriteLine(a);
                uint b = uint.MaxValue;
                Console.WriteLine(b);
                Console.WriteLine(a + b);
                Console.WriteLine((a + b).GetType().Name);
                long c = long.MaxValue;
                Console.WriteLine(b + c);
                Console.WriteLine((b + c).GetType().Name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Buy");
        }
    }
}
