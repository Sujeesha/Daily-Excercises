using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = SongRepo.GetSongs();
            Console.WriteLine("Enter a search type:");
            Console.WriteLine("1.Song Type");
            Console.WriteLine("2.Date of download");
            Console.WriteLine("3.Rating");
            Console.WriteLine("Enter your choice:");
            int ch = int.Parse(Console.ReadLine());
            Song s = new Song();
            SONGBo s1 = new SONGBo();
            do
            {
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the type:");
                        s.SongType = Console.ReadLine();
                        List<Song> songs1 = SONGBo.FindSong(ls, s.SongType);
                        foreach (Song S in songs1)
                        {
                            Console.WriteLine(S.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the date:");
                        s.DateDownloaded = DateTime.Parse(Console.ReadLine());
                        List<Song> songs2 = s1.FindSong(ls, s.DateDownloaded);
                        foreach (Song S in songs2)
                        {
                            Console.WriteLine(S.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the Rating:");
                        s.Rating = double.Parse(Console.ReadLine());
                        List<Song> songs3 = s1.FindSong(ls, s.Rating);
                        foreach (Song S in songs3)
                        {
                            Console.WriteLine(S.ToString());
                        }
                        break;
                }
            } while (ch != 0);
            Console.WriteLine("wrong choice");
        }

    }

}
