using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>(); //list is defined for collecting songs
            Console.WriteLine("Enter the number of songs");
            int N= int.Parse(Console.ReadLine());
            //collecting the song details and split according to comma store each details
            //is stored in array and added to list
            for(int i = 0; i < N; i++)
            {
                string[]songs = Console.ReadLine().Split(',');
                string name = songs[0]; 
                string artist= songs[1];    
                string songType= songs[2];  
                DateTime dateDownloaded = DateTime.Parse(songs[3]);
                double rating = double.Parse(songs[4]); 
                int numberOfDownloads = int.Parse(songs[5]);
                Song s=new Song(name,artist,songType,rating,numberOfDownloads,dateDownloaded);
                list.Add(s);    

            }
            //the sorted dictionary is added into 
            SortedDictionary<string,int>sdn = new SortedDictionary<string,int>();
            sdn = Song.CalculateTypeCount(list);
            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach (var item in sdn) 
            { 
                Console.WriteLine(" {0} {1,15}", item.Key,item.Value);
            }



        }
       
    }
}
