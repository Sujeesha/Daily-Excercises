using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan ts = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + ts);
            Console.WriteLine(dt2 - dt1); 
            Console.WriteLine(dt1 == dt2); 
            Console.WriteLine(dt1 != dt2); 
            Console.WriteLine(dt1 > dt2); 
            Console.WriteLine(dt1 < dt2); 
            Console.WriteLine(dt1 >= dt2); 
            Console.WriteLine(dt1 <= dt2);
        }
    }
}
