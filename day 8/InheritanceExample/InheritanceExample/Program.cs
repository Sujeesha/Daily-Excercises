//Example of inheritance using Fruit as base class and Orange as an derived class
using System;


namespace InheritanceExample
{
    //Main class
     class Program
    {
        static void Main(string[] args)
        {
            Orange o = new Orange(1,"Nagpur orange","Maharashtra");
            o.print();
        }
    }
    //Base class
    class Fruit
    {
        //field and property of fruit number
        private int _no;
        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        //field and property of fruit name
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                    _name = value;
                else
                    Console.WriteLine("invalid fruit name");
            }
        }
        //zero-argument constructor
        public Fruit()
        {

        }
        //parameterized constructor
        public Fruit(int no, string name) {
            _no = no;
            _name = name;
        }
        //Printing fruit number and fruit name
        public void print()
        {
            Console.WriteLine("fruit number: " + No);
            Console.WriteLine("fruit name: " + Name);
        }
    }
    //derived class
    class Orange : Fruit
    {
        string[] origins = { "Maharashtra", "Himachal", "Telungana" };
        //field and property of origin
        private string _origin;
        public string Origin
        {
            get { return _origin; }
            set
            {
                Array.Sort(origins);       //sorting origins array
                if (Array.BinarySearch(origins, value) >= 0) // inputted origin is in origins then
                    _origin = value;                      //value of binary search is >= 0
                else
                    Console.WriteLine("Invalid origin");
            }
        }
        //zero argument constructor for derived class Orange
        public Orange()
        {

        }
        //Parameterized constructor for derived class Orange
        public Orange(int no,string name,string origin) : base(no, name)
        {
            Origin = origin;
        }
        //print origin of the fruit
        public new void print()
        {
            base.print();
            Console.WriteLine("origin of fruit: " + Origin);
        }
    }
    
}
