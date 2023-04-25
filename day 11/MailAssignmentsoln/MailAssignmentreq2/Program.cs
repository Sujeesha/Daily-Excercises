using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MailAssignmentreq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail> li = new List<Mail>();
            Console.WriteLine("enter the name of mail");
            string folder;
            folder = Console.ReadLine();
            Mail m= new Mail();
            MailFolder mf = new MailFolder(folder, li);
            while (true) { 
            Console.WriteLine("1.Add mail");
            Console.WriteLine("2.Delete mail");
            Console.WriteLine("3.Display mails");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the details of mail in CSV format:");
                    string details = Console.ReadLine();
                    m =Mail.CreateMail(details);
                    mf.AddMailToFolder(m);  
                    Console.WriteLine("mail added successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter the id to be deleted");
                    int id=int.Parse(Console.ReadLine());
                    mf.RemoveMailFromFolder(id);
                    break;
                case 3:
                    mf.DisplayMails();
                    break;

                case 4:
                    break;
            }
        }
           
        }
}
}
