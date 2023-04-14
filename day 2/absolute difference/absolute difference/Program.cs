using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absolute_difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0,result;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());
            result = difference(n);
            Console.WriteLine("the result is {0}", result);

        }
        static int difference(int n)
        {
            int diff = 0;
            int result = 0;
            if (n > 51)
            {
                diff = n - 51;
                result = 3 * diff;
                return result;
            }
            else
            {
                diff = 51 - n;
                return diff;    
            }
           
        }
    }
}
