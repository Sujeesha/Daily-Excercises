//Examples of List
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add prime elements to List and print it
            List<int> PrimeNumbers = new List<int>();
            PrimeNumbers.Add(1);    
            PrimeNumbers.Add(3);
            PrimeNumbers.Add(5);
            PrimeNumbers.Add(7); 
            foreach (int i in PrimeNumbers)
            {
                Console.WriteLine(i);   
            }


        }
    }
}
