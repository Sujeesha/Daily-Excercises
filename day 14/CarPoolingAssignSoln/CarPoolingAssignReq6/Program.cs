using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static CarPoolingAssignReq6.MemberCar;

namespace CarPoolingAssignReq6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var members = new List<Member>();
            {
                new Member { Id = 1, FirstName = "joe", LastName = "root", Email = "joe.root@.com", ContactNumber = "1234567890", LicenceNumber = "AH1", LicenceStartDate = DateTime.Parse("12-12-2001"), LicenceExpiryDate = DateTime.Parse("12-12-2010") };
                new Member { Id = 2, FirstName = "ben", LastName = "stokes", Email = "ben.stokes@.com", ContactNumber = "2345678901", LicenceNumber = "AH2", LicenceStartDate = DateTime.Parse("12-12-2002"), LicenceExpiryDate = DateTime.Parse("12-12-2011") };
                new Member { Id = 1, FirstName = "virat", LastName = "kohli", Email = "virat.kohli@a.com", ContactNumber = "3456789012", LicenceNumber = "AH3", LicenceStartDate = DateTime.Parse("12-12-2003"), LicenceExpiryDate = DateTime.Parse("12-12-20102") }; 
                    };
            var cars = new List<Car>()
            {
                new Car{Id=1,Model="i10",Name="sports",MakeYear=2007,Company="Hyundai",ComfortLevel=8},
                new Car{Id=2,Model="alto",Name="kx1",MakeYear=2008,Company="Maruthi",ComfortLevel=6},
                new Car{Id=3,Model="polo",Name="topline",MakeYear=2010,Company="Volks",ComfortLevel=5},
                new Car{Id=4,Model="kwid",Name="lxi",MakeYear=2010,Company="Renault",ComfortLevel=5}
            };

            var MemberCars = new List<MemberCar>()
            {
                new MemberCar{MemberId=1,CarId=2,CarRegistrationNumber="TN66AB4214",CarColor="brown"},
                new MemberCar{MemberId=2,CarId=1,CarRegistrationNumber="TN38BR9689",CarColor="white"},
                new MemberCar{MemberId=3,CarId=4,CarRegistrationNumber="TN61EB4004",CarColor="white"}
            };
            var carPoolingSystem = new CarPoolingSystem(members, cars, MemberCars);
            Console.WriteLine("Color to search");
            var color=Console.ReadLine().ToLower();
            var memberCarsByColor = carPoolingSystem.GroupByColor();
            if (memberCarsByColor.ContainsKey(color))
            {
                var memberCarsWithColor = memberCarsByColor[color];
                Console.WriteLine("number of member cars:" + memberCarsWithColor.Count);
                Console.WriteLine("enter the member car details");
                for (int i = 0; i < memberCarsWithColor.Count; i++)
                {
                    Console.WriteLine((i + 1) + ",");
                    var input = Console.ReadLine().Split(',');
                    memberCarsWithColor[i].Id = int.Parse(input[0]);
                    memberCarsWithColor[i].CarId = int.Parse(input[1]);
                    memberCarsWithColor[i].CarRegistrationNumber = input[2];
                    memberCarsWithColor[i].CarColor = input[3];

                }
                var registrationNumbers = memberCarsWithColor.Select(mc => mc.CarRegistrationNumber).ToList();
                Console.WriteLine(color + "car registration numbers:");
                Console.WriteLine(string.Join(color, registrationNumbers));
            }
            else 
            { 
                Console.WriteLine("no member cars found for " + color + "cars");
            }

            }
        }
    }

