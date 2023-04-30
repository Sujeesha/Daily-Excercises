using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq4
{
    abstract class Car
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       
        public Car()
        { }
        public Car(long id, string name)
        {
            Id = id;
            Name = name;
            
        }
        public abstract double CalculateDriveCost(double km);
               

    }
}
