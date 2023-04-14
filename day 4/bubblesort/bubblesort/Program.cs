//bubble sort
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 6, -3, 0, 9, 15, -6 };
            int temp;
            Console.WriteLine("original numbers");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                for (int i=0; i < numbers.Length-1; i++) 
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        
                    }

                }
            }
            Console.WriteLine("Sorted array");
            Console.WriteLine()
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
