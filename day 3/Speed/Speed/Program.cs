using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double distance, time, speed_km,speed_miles;
            Console.WriteLine("Enter the distance");
            distance=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            time=double.Parse(Console.ReadLine());  
            speed_km=distance/time;
            speed_miles = speed_km * 0.6;
            Console.WriteLine("The speed in km/hr is {0}", speed_km);
            Console.WriteLine("The speed in miles/hour is {0}", speed_miles);
        }
    }
}
