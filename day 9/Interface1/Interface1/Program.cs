//Interface inheritance example

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("Enter 'c' for Circle and 's' for square");
            string ch= Console.ReadLine();
            if (ch == "c")
            {
                fig=new Circle();
            }
            else if (ch == "s")
            {
                fig=new Square();
            }
            fig.Dimension = 8;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }
    }

}


