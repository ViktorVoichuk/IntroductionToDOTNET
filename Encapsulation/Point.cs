﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Point
    {
        /*double x;
		double y;
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				//if(value...)......
				x = value;	//value - открывает доступ к переданному значению
			}
		}
		public double Y
		{
			get { return y; }
			set { y = value; }
		}

		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			this.x = x;	//В языке C# отсутствуют указатели, а следовательно отсутсвует оператор '->'
		}
		public void SetY(double y)
		{
			this.y = y;
		}*/
        double x;
        double y;
        public double X 
        {   get { return x; }
            set
            {
                if (value > 700) value = 700;
                if (value < 0) value = 0;
                x = value;
            } 
        }   //Автосвойства для 'X'
        public double Y 
        {
            get { return y; }
            set
            {
                if (value > 700) value = 700;
                if (value < 0) value = 0;
                y = value;
            }
        }   //Автоствойства для 'Y'

        //			  Constructors:
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Constructor:\t{this.GetHashCode()}");
        }
        public Point(Point other)
        {
            this.X = other.X;
            this.Y = other.Y;
            Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
        }

        //				Operators:
        public static Point operator +(Point left, Point right)
        {
            Point res = new Point();
            res.X = left.X + right.X;
            res.Y = left.Y + right.Y;
            return res;
        }
        public static Point operator ++(Point obj)
        {
            obj.X++;
            obj.Y++;
            return obj;
        }
        public static Point operator --(Point obj)
        {
            obj.X--;
            obj.Y--;
            return obj;
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.X == right.X && left.Y == right.Y;
        }
        public static bool operator !=(Point left, Point right)
        {
            return !(left==right);
        }

        //				Methods:
        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));//Pov(основание,степень)
        }
        public static double Distance(Point first, Point second)
        {
            return first.Distance(second);
        }
        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y};");
        }
    }
}

/*
-----------------------
private
public
protected
internal
protected internal
-----------------------
Properties
value
-----------------------
 */