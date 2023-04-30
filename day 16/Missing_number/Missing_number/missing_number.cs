using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int N=int.Parse(Console.ReadLine());
            int[]A=new int[N-1];
            Console.WriteLine("Enter the array");
            for(int i=0; i < N-1; i++)
            {
                A[i]=int.Parse(Console.ReadLine());
            }
            int miss_num=MissingNumber(N,A);
            Console.WriteLine("missing number is {0}",miss_num);

        }
        static int MissingNumber(int N, int[] A)
        {
            int sum_nat_num =( N*(N + 1))/ 2;
            int sum_array = 0;
            for(int i = 0; i < N-1; i++)
            {
                sum_array += A[i];  
            }
            return sum_nat_num-sum_array;   

        }
    }
}
