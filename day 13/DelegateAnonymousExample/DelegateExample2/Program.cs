using System;
public delegate int Add(int i, int j); 

namespace DelegateExample2
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int result;
            Add sum = delegate (int i, int j)
            {
                return i + j;
            };
            result = sum(10, 20); 
            Console.WriteLine(result);
        }
    }
}
