using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaltoBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string result;
            //string answer;

            Console.WriteLine("Enter the number");
            number=int.Parse(Console.ReadLine());
            result = "";
            while(number>1) {
                int remainder = number % 2;
                result = Convert.ToString(remainder) + result;
                number = number / 2;
            }
            result = Convert.ToString(number) + result;
            Console.WriteLine(result);



        }
    }
}
