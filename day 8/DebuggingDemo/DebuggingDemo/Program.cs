//debugging demo
using System;

namespace DebuggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No: ");
            int i =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No: ");
            int j =int.Parse(Console.ReadLine());
            foo(i, j);
            Console.WriteLine("debugging over");
        }
        public static void foo(int x,int y)
        {
            int t = 100;
            for(int i = x; i <= y; i++)
            {
                Console.WriteLine("India");
                t = t + 34;
            }
        }
    }
}
