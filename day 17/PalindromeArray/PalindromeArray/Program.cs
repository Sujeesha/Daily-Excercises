using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dig;
            Console.WriteLine("Enter the value for N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Array");
            int[] A = new int[N];
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < N; i++)
            {
                while (A[i] > 0)
                {
                    dig = A[i] % 10;
                    B[i] = B[i] * 10 + dig;
                    A[i] = A[i] / 10;
                }

            }
            for(int i=0; i < N; i++)
            {
                Console.WriteLine(B[i]);
            }
            ArrEqual(A,B);

        }
        static void ArrEqual(int[] A, int[]B)
        {
            if (A.Equals(B) == true)
            {
                Console.WriteLine("1");
                return ;
            }
            else
            {
                Console.WriteLine("0");
                return ;
            }
        }
    }
}

