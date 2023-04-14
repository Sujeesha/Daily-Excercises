using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers are: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                   
                    Console.WriteLine(i);
                }
            }
        }
    }
}
