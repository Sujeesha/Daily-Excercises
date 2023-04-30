using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member>list= new List<Member>();   
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member{0}", i + 1);
                Console.WriteLine("Id:");
                long id=long.Parse(Console.ReadLine());
                Console.WriteLine("first name:");
                string firstName=Console.ReadLine();
                Console.WriteLine("last name:");
                string lastName=Console.ReadLine();
                Console.WriteLine("email:");
                string email=Console.ReadLine();
                Console.WriteLine("contact number:");
                string contactNumber=Console.ReadLine();
                Console.WriteLine("licence number");
                string licenceNumber=Console.ReadLine();
                Console.WriteLine("licence start date:");
                DateTime licenceStartDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("licence expiry date:");
                DateTime licenceExpiryDate= DateTime.Parse(Console.ReadLine());
                Member m = new Member(id, firstName, lastName, email, contactNumber, licenceNumber, licenceStartDate, licenceExpiryDate);
                list.Add(m);

            }
            //Console.WriteLine();
            int j = 1;
            foreach (var item in list)
            {
                Console.WriteLine("Member {0}", j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("Member 1 is same as Member 2");
            }
            else
            {
                Console.WriteLine("Member 1 and Member 2 are different");
            }

        }
    }
}
