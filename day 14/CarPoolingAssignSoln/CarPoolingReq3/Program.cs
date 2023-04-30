using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingReq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:1");
                Console.WriteLine("1.Validate Car registration number");
                Console.WriteLine("2.Convert Car registration number");
                Console.WriteLine("3.Valid Driving License");
                Console.WriteLine("Enter choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("car registration number");
                        string _regnum = Console.ReadLine();
                        if (Car.ValidCar(_regnum))
                        {
                            Console.WriteLine(_regnum + ":is valid");
                        }
                        else
                        {
                            Console.WriteLine(_regnum + ":is Invalid");
                        }
                        break;
                    case 2:
                        Console.WriteLine("car registartion number");
                        string regnumcrct = Console.ReadLine();
                        string ConvertCarNum = Car.CnvtCar(regnumcrct);
                        Console.WriteLine(ConvertCarNum);
                        break;
                    case 3:
                        Console.WriteLine("driving license issue date");
                        DateTime _licdt = DateTime.Parse(Console.ReadLine());
                        if (Car.ValidLic(_licdt))
                        {
                            Console.WriteLine(DateTime.Now.Year - _licdt.Year + "years old license-expired");
                        }
                        else
                        {
                            Console.WriteLine(DateTime.Now.Year - _licdt.Year + "year old license-valid");
                        }
                        break;
                }

            }

        }

    }

}










