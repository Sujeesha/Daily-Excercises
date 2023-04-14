// Count frequency of each element of an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayfrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, ctr;

            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
                fr1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            Console.WriteLine("The frequency of all elements of the array : ");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.WriteLine("{0} occurs {1} times ", arr1[i], fr1[i]);
                }
            }
        }
    }
}
