using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 18,25,87,-15,66,23,0,15,37,-20 };
            Console.WriteLine("Input Array Elements :");
            PrintIntegerArray(numbers);
            Console.WriteLine("Sorted Array Elements :");
            PrintIntegerArray(InsertionSort(numbers));
        }
        static int[] InsertionSort(int[] inpArray)
        {
            for (int i = 0; i < inpArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inpArray[j - 1] > inpArray[j])
                    {
                        int temp = inpArray[j - 1];
                        inpArray[j - 1] = inpArray[j];
                        inpArray[j] = temp;
                    }
                }
            }
            return inpArray;
        }
        public static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}
    

