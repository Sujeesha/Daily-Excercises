//Write a program to enter the amount and find out minimum no.of notes required
//to make that amount.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            int number=0;
            Console.WriteLine("Enter the amount");
            amount=int.Parse(Console.ReadLine());
            number = amount / 2000;
            amount = amount % 2000;
            number +=amount / 500;
            amount = amount % 500;
            number +=amount / 200;
            amount = amount % 200;
            number += amount / 100;
            amount= amount % 100;   
            number += amount / 50;
            amount = amount % 50;
            number += amount / 20; 
            amount = amount % 20;   
            number += amount / 10;
            amount = amount % 10;
            number += amount / 5;
            amount=amount % 5;
            number += amount / 1;
            Console.WriteLine("The minimum no.of notes needed: {0}",number);
            

        }
    }
}
