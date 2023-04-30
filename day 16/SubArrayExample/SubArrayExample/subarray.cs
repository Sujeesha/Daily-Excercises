using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Enter the value for N:");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int S;
            Console.WriteLine("Enter the value for S:");
            S = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array:");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            subarraysum( A, N, S);
        }
        static void subarraysum(int[] A, int N, int S)
        {
            int temp = 0;
            ArrayList arr = new ArrayList();
            for (int i = 0; i < N; i++)
            {
                temp = A[i];
                for (int j = i + 1; j < N; j++)
                {
                    temp = temp + A[j];
                    if (temp == S)
                    {
                        arr.Add(i + 1);
                        arr.Add(j + 1);
                        Console.WriteLine("{0} {1}", arr[0], arr[1]);
                        return;
                    }
                }
            }
            if (temp != S)
            {
                arr.Add(-1);
                Console.WriteLine("{0}", arr[0]);
                return;
            }
        }
        }


    
}

