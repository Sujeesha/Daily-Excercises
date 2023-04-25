//Exception handling demo
using System;


namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 10, i = 0;
            int[] a = new int[5];
            try
            {
                k = k / i;               //divide by zero error
                a[12] = 9;               //index out of bounds
                
            }
            catch (DivideByZeroException e) {
                System.Console.WriteLine("Divide by zero");

            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.WriteLine("Index out of bounds");
            }
            finally
            {
                System.Console.WriteLine("finally");
            }
            Console.WriteLine("Remaining program");

        }
    }
}
