using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharashtar", "Mumbai");
            s.Add("Karnataka", "Banglore");
            s.Add("Andrapradesh", "Banglore");
            s.Add("Tamil nadu", "chennai");
            s.Add("Bihar", "Patna");
            //Console.WriteLine(s.ToString());
            Console.WriteLine("Elements in the sorted array:");
            IDictionaryEnumerator e = s.GetEnumerator();
            while (e.MoveNext()) 
            {
                Console.WriteLine(e.Key+"\t"+e.Value);
            }
            foreach(var item  in s.Keys)
            {
                Console.WriteLine(item); 
            }
            
        }
    }
}
