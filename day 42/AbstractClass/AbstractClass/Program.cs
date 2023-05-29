using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBook book = new MyBook();
            Console.WriteLine("Enter the book name:");
            string s = Console.ReadLine();
            book.SetTitle(s);
            Console.WriteLine("The book title is: " + book.GetTitle());
        }
    }
    abstract class Book
    {
        protected string title;
        public abstract void SetTitle(string s);
        public string GetTitle()
        {
            return title;
        }
    }
    class MyBook : Book
    {
        public override void SetTitle(string s)
        {
            title = s;
        }
    }
}


