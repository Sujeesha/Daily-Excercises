using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject
{
    class Account
    {
        public int id;
        //public string name;
        private string _name;
        public string Name
        {
            get { return _name; }   
          
            set
            {
                if (value.Length > 15)
                {
                    throw new ApplicationException("Name should be less than 15 characters");

                }
                _name = value;  
            }
        }

        public decimal balance;
        public void accountcreate(int Id,string Name,decimal Balance)
        {
            id = Id;
            _name = Name;    
            balance = Balance;

        }
        public void displayinfo()
        {
            Console.WriteLine("Account ID" + id);
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Opening balance" + balance);
        }
        public void deposit(decimal amount) 
        {
            balance += amount;
            Console.WriteLine("balance is {0}", balance);
        }
        public void withdraw(decimal amount)
        {
            this.balance -= amount;
            Console.WriteLine("balance after withdrawal is {0}", balance);
        }

        
    }
}
