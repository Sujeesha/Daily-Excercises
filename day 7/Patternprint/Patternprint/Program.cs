//Display the pattern like right angle using an asterisk
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patternprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;

            Console.WriteLine(" number of rows : ");
            rows = int.Parse(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
            }
        }
    }
}
