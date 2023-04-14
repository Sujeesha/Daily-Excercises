using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constrctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 500;
            Cons e1 = new Cons();
            Cons e2 = new Cons(250, "Tara", 50000);
            Console.WriteLine("enter emplo id");
            e1.EmpId=int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            e1.Name=Console.ReadLine();
            Console.WriteLine("salary");
            e1.Salary=decimal.Parse(Console.ReadLine());
        }
    }
}
