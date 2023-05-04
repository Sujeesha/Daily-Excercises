using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lilly", "hibiscus", "daffodil" };
            //linq
            var fQuery=
                from flower in flowers          
                where(flower.StartsWith("d"))
                select flower;
            foreach(string f in fQuery) 
            {
                Console.WriteLine(f);
            }
            var lquery=
                from flower in flowers

        }
    }
}
