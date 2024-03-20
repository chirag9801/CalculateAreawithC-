using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Triangle");
            int Base = ReadInt("enter base of triangle: ");
            int Height = ReadInt("enter height: ");
            int area = Area(Base, Height);
            Console.WriteLine($"Area of triangle is {area} ");
            
        }

        static int Area(int Base, int height)
        {
            int area = (Base*height)/2;
            return area;

        }


        static int ReadInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
