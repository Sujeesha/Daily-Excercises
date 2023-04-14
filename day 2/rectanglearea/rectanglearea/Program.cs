using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectanglearea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 0, width = 0, area;
            Console.WriteLine("enter the length");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the width");
            width = double.Parse(Console.ReadLine());
            area = CalcArea(length, width);
            Console.WriteLine("area of rectangle having length {0} and width {1} is {2}", length, width, area);
        }
        static double CalcArea(double length, double width)
        {
            double area = 0;
            return area = length * width;
        }
        
    }
}
