//Inheritance example 2
using System;
using System.Xml.Linq;


namespace inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Electronicphone phone = new Electronicphone("electronic","Digital");
            phone.print();
        }
    }
    class Telephone
    {
        protected string _phonetype;
        public string Phonetype
        {
            get { return _phonetype; }
            set
            {
      
                    _phonetype = value;
                
            }
        }
        protected Telephone() { }

        public Telephone(string phonetype)
        {
            _phonetype = phonetype;
        }
        public void print()
        {
            Console.WriteLine("Ringing the " + Phonetype);
        }
    }
    class Electronicphone : Telephone
    {
        string[] types = { "Analog", "Digital" };
        //field and property of origin
        private string _types;
        public string Types
        {
            get { return _types; }
            set
            {
                Array.Sort(types);       //sorting origins array
                if (Array.BinarySearch(types, value) >= 0) // inputted origin is in origins then
                    _types = value;                      //value of binary search is >= 0
                else
                    Console.WriteLine("Invalid type");
            }
        }
        //zero argument constructor for derived class Orange
        public Electronicphone()
        {

        }
        //Parameterized constructor for derived class Orange
        public Electronicphone ( string phonetype, string types) : base(phonetype)
        {
            Types = types;
        }
        //print origin of the fruit
        public new void print()
        {
            base.print();
            Console.WriteLine("type of the electronic phone: " + Types);
        }
    }
}
