using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constrctor
{
    public class Cons
    {
        public int EmpId;
        public string Name;
        public decimal Salary;
        public Cons()
        {

        }
        public Cons(int EmpId,string Name,decimal Salary)
        {
            this.EmpId = EmpId;
            this.Name = Name;   
            this.Salary = Salary;   
        }

    }
}
