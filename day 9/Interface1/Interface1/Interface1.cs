using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IFigure     //interface
    {
        int Dimension { get; set; }  //field and property
        double Area();   //method
        double Perimeter();  //method
    }
    class Circle : IFigure      //derived class
    {
        private int _Radius;   //fields and properties
        public int Dimension
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double Area()
        {
            return Math.PI * _Radius * _Radius;
        }
        public double Perimeter()
        {
            return 4 * Math.PI * _Radius * _Radius;

        }

    }
    class Square : IFigure                //derived class
    {
        private int _Dimension;
        public int Dimension
        {
            get { return _Dimension; }
            set { _Dimension = value; }
        }
        public double Area()
        {
            return _Dimension * _Dimension;
        }
        public double Perimeter()
        {
            return 4 * _Dimension;

        }
    }
}
