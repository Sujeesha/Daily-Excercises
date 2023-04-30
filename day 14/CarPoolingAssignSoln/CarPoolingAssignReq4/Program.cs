using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("id");
            long id=long.Parse(Console.ReadLine());
            Console.WriteLine("name");
            string name= Console.ReadLine();
            Console.WriteLine("type");
            string type=Console.ReadLine();
            Console.WriteLine("distance");
            double distance=double.Parse(Console.ReadLine());
            Car car;
            if (type == "hatchback")
            {
                Console.WriteLine("power windows");
                bool powerWindowsEnabled=bool.Parse(Console.ReadLine());
                Console.WriteLine("automatic");
                bool automaticGear=bool.Parse(Console.ReadLine());  
                car=new HatchBack(powerWindowsEnabled, automaticGear,id,name);
                HatchBack hatchback = new HatchBack(id, name, powerWindowsEnabled, automaticGear);

                double hatchbackCost = hatchback.CalculateDriveCost(distance);

                Console.WriteLine($"Cost is Rs {Math.Round(hatchbackCost, 0)}");
            }
            if (type == "sedan")
            {
                Console.WriteLine("abs enabled");
                bool absEnabled=bool.Parse(Console.ReadLine());
                Console.Write("Boot Space (in litres): ");

                int bootSpace = Int32.Parse(Console.ReadLine());

                Sedan sedan = new Sedan(id, name, absEnabled, bootSpace);

                double sedanCost = sedan.CalculateDriveCost(distance);

                Console.WriteLine($"Cost is Rs {Math.Round(sedanCost, 0)}");

            }
            if(type =="utility car")
            {
                Console.Write("Rear Cooling Vents (true/false): ");

                bool rearCoolingVents = Convert.ToBoolean(Console.ReadLine());

                UtilityCar utilityCar = new UtilityCar(id, name, rearCoolingVents);

                double utilityCarCost = utilityCar.CalculateDriveCost(distance);

                Console.WriteLine($"Cost is Rs {Math.Round(utilityCarCost, 0)}");
            }

            

        }
    }
}
