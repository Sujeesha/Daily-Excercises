using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
     class Shape
    {
        public virtual void Drawshape()     //virtual and overriding keyword is used for polymorphism 
        {
            Console.WriteLine("Drawing shape");
        }
    }
    class Circle : Shape
    {
        public override void Drawshape()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Drawshape()
        {
            Console.WriteLine("Drawing Rectangle");
        }

    }
}
