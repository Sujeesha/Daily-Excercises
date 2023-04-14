//Bank application program
using System;
using System.Security.Principal;

namespace MenuProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("ACCOUNT APPLICATIONS");
                Console.WriteLine("****************************");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Display Account information");
                Console.WriteLine("3.Deposit money");
                Console.WriteLine("4.Withdraw money");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter your choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter your ID");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter your opening balance");
                        decimal balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.accountcreate(id, Name, balance);
                        break;
                    case 2:
                        if (a != null)
                        {
                            a.displayinfo();
                        }
                        else
                        {
                            Console.WriteLine("You have no account");
                        }
                        break;
                    case 3:
                        if (a != null)
                        {
                            a.deposit(5000);
                        }
                        else
                        {
                            Console.WriteLine("You have no account");
                        }
                        break;
                    case 4:
                        if (a != null)
                        {
                            a.withdraw(5000);
                        }
                        else
                        {
                            Console.WriteLine("You have no account");
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }
            }
            while (ch != 0);
            Console.WriteLine("Thank you");

            
        }    
    }
}
