using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age=int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are not eligible for voting");
            } 
            else
            {
                Console.WriteLine("You are  eligible for voting");
            }
        }
    }
}
