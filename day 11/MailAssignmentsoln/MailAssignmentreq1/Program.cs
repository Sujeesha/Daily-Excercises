using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAssignmentreq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail> list = new List<Mail>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter mail{0} details: ");
                string[] s = Console.ReadLine().Split(',');
                Mail m = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.Parse(s[5]), double.Parse(s[6]));
                list.Add(m);

            }
            Console.WriteLine();
            int j = 1;
            foreach (var item in list)
            {
                Console.WriteLine("Mail{0}", j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("mail 1 is same as mail 2");
            }
            else
            {
                Console.WriteLine("mail 1 and mail 2 are different");

            }

        }
    }
    }
}
