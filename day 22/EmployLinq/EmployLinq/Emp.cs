using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployLinq
{
     class Emp
    {
        private string _name;
        public string Name
        {
            get { return _name; }    
            set { _name = value; }   
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }   

        }
        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Emp()
        {

        }
        public Emp(string name,string city,int salary)
        {
            _name = name;   
            _city = city; 
            _salary = salary;

        }

    }
}
