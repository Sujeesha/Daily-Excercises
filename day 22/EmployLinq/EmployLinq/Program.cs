using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> Emplist = new List<Emp>();
            Emplist.Add(new Emp("Ramu","Trivandrum",5000));
            Emplist.Add(new Emp("Ansh","Kochi",3000));
            Emplist.Add(new Emp("Dev","Trivandrum",4500));
            Emplist.Add(new Emp("Rajini","Mumbai",5000));
            Emplist.Add(new Emp("Tina","Mumbai",3500));
            Emplist.Add(new Emp("Tom","Delhi",3000));
            Emplist.Add(new Emp("Gayu","Kochi",4500));
            Emplist.Add(new Emp("Jai","Mumbai",6000));
            var empQuery = from Emp emp in Emplist
                           orderby emp.City
                           group emp by emp.City;
            foreach(var e  in empQuery)
            {
                Console.WriteLine("Employee with  " + e.Key + "  City");
                foreach(var name in e)
                {
                    Console.WriteLine(" " + name.Name);
                }
            }
            var empQuery1 = from Emp emp in Emplist
                           orderby emp.Salary
                           group emp by emp.Salary;
            foreach (var e in empQuery1)
            {
                Console.WriteLine("Employee with  " + e.Key + "  Salary");
                foreach (var name in e)
                {
                    Console.WriteLine(" " + name.Name);
                }
            }

        }
        
    }
}
