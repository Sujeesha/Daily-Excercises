using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter the value for a:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for b:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("a:{0}  b:{1}", a, b);
            get(a, b);

        }
        static void get(int a, int b)
        {
            List<int> list = new List<int>();
            list.Add(b);
            list.Add(a);
            foreach (int x in list)
            {
               Console.Write(x+" ");
            }
            return ;


        }
    }
}

