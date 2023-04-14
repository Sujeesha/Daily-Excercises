using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mail1 details");
            Mail m1=new Mail();
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int input1 = int.Parse(inputs[0]);
            string input2 = inputs[1];
            string input3 = inputs[2];
            string input4 = inputs[3];
            string input5 = inputs[4];
            DateTime input6 = DateTime.Parse(inputs[5]);
            double input7 = input[6];
            
            

            Console.WriteLine("Enter mail 2 details");
            Mail m2 = new Mail();
            string inp1 = Console.ReadLine();
            string[] inps1 = inp1.Split(',');
            int inpu1 = int.Parse(inps1[0]);
            string inpu2 = inps1[1];
            string inpu3 = inps1[2];
            string inpu4 = inps1[3];
            string inpu5 = inps1[4];
            DateTime inpu6 = DateTime.Parse(inps1[5]);
            double inpu7 = double.Parse(inps1[6]);
            Console.WriteLine("Mail 1");
            Console.WriteLine(m1);
            string[] spts = input.Split(',');
            foreach (string s in spts)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Mail 2");
            Console.WriteLine(m2);
            string[] spts1 = inp1.Split(',');
            foreach(string s1 in spts1)
            {
                Console.WriteLine(s1);
            }
        }
    }
}
