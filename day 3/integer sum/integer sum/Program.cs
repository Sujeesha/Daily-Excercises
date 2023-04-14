//Write a Code Block to compute the sum of the two given integer values.
//If the two values are the same, then return triple their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace integer_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0,result;
            Console.WriteLine("Enter the first number");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b=int.Parse(Console.ReadLine());
            result = suminteger(a,b);
            Console.WriteLine("the sum of {0} and {1} is {2} ",a,b,result);

        }
        static int suminteger(int a,int b)
        {
            int total = 0;
            if (a == b)
            {
                total = 3 * (a + b);   
            }
            return total;   


        }
    }
}
