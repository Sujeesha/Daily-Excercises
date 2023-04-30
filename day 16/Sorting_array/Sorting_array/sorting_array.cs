using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array:");
            int[] arr = new int[N];
            int[] arr2 = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            sort012(arr,N); //USING SORTING KEYWORD
            sort012_1(arr, N); //USING BUBBLE SORT
        }
            //using sorting keyword
            static void sort012(int[] arr,int N)
            {
                Array.Sort(arr);
                for (int i = 0; i < N; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            return;
            }
            //using bubble sort
            static void sort012_1(int[]arr,int N) 
            { 
            for(int j = 0; j < N-1; j++)
            {
                for (int i=0; i < N-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i < N;i++)
            {
                
                Console.Write(arr[i]+" ");  
            }
            }
    }
}
