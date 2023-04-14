//count the number of alphabets,digits and special characters in the string
using System;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace countofalphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int alpha = 0;
            int digit = 0;
            int spec_char = 0;
            int i = 0;
            Console.WriteLine("enter the string");
            s= Console.ReadLine();
            while (i < s.Length)
            {
                if ((s[i] >= 'a' && s[i] <= 'z')|| (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    alpha++;    
                }
                else if (s[i]>='0' && s[i] <= '9')
                {
                    digit++;    
                }
                else
                {
                    spec_char++;
                }
                i++;
            }
            Console.WriteLine("total number of alphabets in the string is {0}", alpha);
            Console.WriteLine("total number of digits in the string is {0}",digit);
            Console.WriteLine("total number of special characters is {0}", spec_char);
            Console.WriteLine("number of alphabets are {0},number of digits are {1} and number of special characters are {2}", alpha, digit, spec_char);
        }
    }
}
