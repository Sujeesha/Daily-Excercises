//To print a number odd or even
using System;


namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Enter the number");  
            a=int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The {0} is even number", a);
            }
            else
            {
                Console.WriteLine("The {0} is odd number", a);
            }
        }
           

        
    }
}
