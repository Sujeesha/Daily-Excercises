//calculate area of circle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circlearea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 0.0, area;
            Console.WriteLine("Enter the radius");
            radius=double.Parse(Console.ReadLine());
            area = CalcArea(radius);
            Console.WriteLine("Area of circle having radius {0} is {1}", radius, area);


        }
        static double CalcArea(double radius)
        {
            double area = 0.0;
            area = 3.14 * radius * radius;
            return area;
        }
    }
}
