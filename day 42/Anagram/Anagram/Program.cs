using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string s2 = Console.ReadLine();
            Console.WriteLine(Anagram(s1, s2) ? "Anagram" : "Not Anagram");
        }
        static bool Anagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            char[] char1 = s1.ToLower().ToCharArray();
            char[] char2 = s2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            for (int i = 0; i < char1.Length || i < char2.Length; i++)
            {
                if (char1[i] != char2[i]) { return false; }
            }
            return true;
        }
    }
}