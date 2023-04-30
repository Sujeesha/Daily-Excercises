using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq4
{
     class Sedan:Car
    {
        private bool _absEnabled;
        public bool AbsEnabled
        {
            get { return _absEnabled; }
            set { _absEnabled = value; }
        }
        private Int32 _bootSpace;
        public Int32 BootSpace
        {
            get { return _bootSpace; }  
            set { _bootSpace = value; } 
        }
        public Sedan()
        {

        }
        public Sedan(long id,string name,bool absEnabled, Int32 bootSpace):base(id,name)
        {
            AbsEnabled = absEnabled;
            BootSpace = bootSpace;
        }
        public override double CalculateDriveCost(double km)
        {
            double cost = 0;
            if (BootSpace > 600)
            {
                cost = 15 + (15 * 0.20);
            }
            else
            {
                cost = 15;
            }
            return cost * km;

        }

    }
}


