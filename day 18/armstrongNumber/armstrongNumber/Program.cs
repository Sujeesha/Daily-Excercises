using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three digit number:");
            int N=int.Parse(Console.ReadLine());
            ArmStrongNumber(N);
            
        }
        static void ArmStrongNumber(int N)
        {
            
            int sum = 0;
            int rem = 0;
            int temp = N;

            while (N > 0)
            {
                rem = (N % 10);
                sum += rem * rem * rem;               
                N = N / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            return;


        }
    }
}
