//print multiples
using System;


namespace MultiplesOfSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int i = 0;
            int multi = 0;
            Console.WriteLine("enter the number");
            a=int.Parse(Console.ReadLine());
            for(i = 0; i <= 100; i++)
            {
                multi = i * a;
                Console.WriteLine(multi);
            }
            
        }
    }
}
