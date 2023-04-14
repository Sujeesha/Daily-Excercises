//Find maximum and minimum element in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int i, max, min, n;

            Console.Write("Input the number of elements to be stored in the array :");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            max = arr1[0];
            min = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }


                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine("Maximum element is : {0} ", max);
            Console.WriteLine("Minimum element is : {0} ", min);
        

    }
    }
}
