using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assign default value
            DateTime dt= new DateTime();
            Console.WriteLine(dt); 
            Console.WriteLine(dt.ToString());
            //assign present date and time
            DateTime dt1 =  DateTime.Now;
            Console.WriteLine(dt1);
            //assign specific date
            DateTime dt3 = new DateTime(2015,10,28);
            Console.WriteLine(dt3);
            Console.WriteLine(dt3.ToString("dd MMM yyyy"));
            //assign specific date and time
            DateTime dt4 = new DateTime(2015, 10, 28,5,30,59);
            Console.WriteLine(dt4);
            Console.WriteLine(dt4.ToString("dd MMMM yyyy HH: mm:ss"));
            //print utc time
            DateTime dt5 = DateTime.UtcNow;
            Console.WriteLine(dt5);
            //Maximum value
            DateTime dt6 = DateTime.MaxValue;
            Console.WriteLine(dt6); 
            //Minimum value
            DateTime dt7 = DateTime.MinValue;
            Console.WriteLine(dt7);
            DateTime dt8 = new DateTime(2015, 10, 28);
            //Print day of the year,day of week,day.....
            Console.WriteLine(dt8.DayOfYear);
            Console.WriteLine(dt8.Day);
            Console.WriteLine(dt8.DayOfWeek);  
            Console.WriteLine(dt4.Hour); 


        }
    }
}
