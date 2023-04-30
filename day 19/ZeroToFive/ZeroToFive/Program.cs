using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ZeroToFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the vaue for T");
            int T=int.Parse(Console.ReadLine());
            string[] A = new string[T];
            for (int i=0;i<T;i++)
            {
                A[i] = Console.ReadLine();
                
            }
            convertFive(T, A);
            
        }
        static void convertFive(int T, string[]A)
        {
            for (int i = 0; i < T; i++)
            {

                A[i] = A[i].Replace("0", "5");
            }
            for(int i = 0; i < T; i++)
            {
                Console.WriteLine(A[i]);
            }
            return;
        }
    }
}
