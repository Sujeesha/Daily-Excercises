using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = SongRepo.GetAllSongs();
            //Console.WriteLine("Name\t\t Artist\t\tSong Type\t\tNo of Downloads\t\tRating\t\tDate Downloaded");
            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            ls.Sort();
            Console.WriteLine("Sorted Song List on Name");
            foreach (Song s in ls)
                Console.WriteLine(s);
            Console.WriteLine();
            ls.Sort(new RatingComparer());
            Console.WriteLine("Sorted Song List on Rating");
            foreach (Song s in ls)
                Console.WriteLine(s);
        }
    }
    
}
