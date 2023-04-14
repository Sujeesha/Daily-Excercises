//write a program to enter the amount and find out minimum no.of each of notes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            int number = 0;
            Console.WriteLine("Enter the amount");
            amount = int.Parse(Console.ReadLine());
            number = amount / 2000;
            amount = amount % 2000;
            Console.WriteLine("No.of 2000 notes are {0}", number);
            int number1 =(amount / 500);
            amount = amount % 500;
            Console.WriteLine("No.of 500 notes are {0}", number1);
            int number2 = amount / 200;
            amount = amount % 200;
            Console.WriteLine("No.of 200 notes are {0}", number2);
            int number3 = amount / 100;
            amount = amount % 100;
            Console.WriteLine("No.of 100 notes are {0}", number3);
            int number4 = amount / 50;
            amount = amount % 50;
            Console.WriteLine("No.of 50 notes are {0}", number4);
            int number5= amount / 20;
            amount = amount % 20;
            Console.WriteLine("No.of 20 notes are {0}", number5);
            int number6= amount / 10;
            amount = amount % 10;
            Console.WriteLine("No.of 10 notes are {0}", number6);
            int number7 = amount / 5;
            amount = amount % 5;
            Console.WriteLine("No.of 5 notes are {0}", number7);
            int number8= amount / 1;
            Console.WriteLine("No.of 1 notes are {0}", number8);
        }
    }
}
