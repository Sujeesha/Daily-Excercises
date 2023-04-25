using System;
delegate void CountIt();

namespace DelegateAnonymousExample
{
    class AnonMethodDemo
    {
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            };
            count();

        }
    }
}
