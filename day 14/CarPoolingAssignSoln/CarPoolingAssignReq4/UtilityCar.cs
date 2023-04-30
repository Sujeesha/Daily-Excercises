using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq4
{
    class UtilityCar:Car
    {
        private bool _rearCoolingVents;
        public bool RearCoolingVents
        {
            get { return _rearCoolingVents;}
            set { _rearCoolingVents = value;}
        }
        public UtilityCar()
        {

        }
        public UtilityCar(long id,string name,bool rearCoolingVents):base(id,name)
        {
            RearCoolingVents = rearCoolingVents;
        }
        public override double CalculateDriveCost(double km)

        {

            return 18 * km;

        }
    }
}
