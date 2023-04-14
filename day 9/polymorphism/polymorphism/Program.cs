//Example of polymorphism
//For polymorphism inheritance and upcasting are needed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Drawshape();                          //Ans:Drawing shape
            Circle c1 = new Circle();
            c1.Drawshape();                          //Ans:Drawing circle
            Rectangle r1 = new Rectangle();
            r1.Drawshape();                         //Ans:Drawing Rectangle

            //upcasting class circle
            Shape s2 = new Circle();
            s2.Drawshape();                        //Ans:Drawing circle
            //upcasting rectangle class
            Shape s3 = new Rectangle();
            s3.Drawshape();                       //Ans:Drawing Rectangle

            //Array of references of base class referencing derived class object(UPCASTING)
            Shape[] P =
            {
                new Circle(), };
            for (int i = 0; i < P.Length; i++)
            {

            }




            Shape t = null;
            Console.WriteLine("Enter the shape");
            string shape=Console.ReadLine();
            if (shape.ToLower() == "circle")
            {
                t = new Circle();
            }
            else if(shape.ToLower() == "Rectangle")
            {
                t=new Rectangle();
            }


        }

    }
}
