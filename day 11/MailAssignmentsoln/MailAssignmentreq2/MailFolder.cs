using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MailAssignmentreq2
{
    internal class MailFolder
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private List<Mail> _mailList;
        public List<Mail> MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }
        public MailFolder() { }
        public MailFolder(string name, List<Mail> mailList)
        {
            _name = name;
            _mailList = mailList;
        }
        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);
        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in MailList) 
            {
                if (item.Id == id)
                {
                    MailList.Remove(item);
                    count = 1;
                    break;
                }
                
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void DisplayMails()
        {
            if (_mailList.Count == 0)
            {
                Console.WriteLine("No mails to show");
            }
            else
            {
                Console.WriteLine("Mails in {0}\n", _mailList);
                //string mail_
                Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}", "Id", "From",
                    "To", "Subject", "Content", "Received Date", "Size");
           
                foreach (Mail mail in MailList)
                {
                    Console.WriteLine(mail.ToString());
                }
            }
                
            

        }
    }
}
