using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SongGroupReq3
{
    internal class Song
    {
        private string _name;
        public string Name 
        { get { return _name; }
            set { _name = value; }
        }
        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }    
        }
        private string _songType;
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
            }    }
       
        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }
        }
        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }
        }
        public Song()
        {

        }
        public Song(string name, string artist, string songType, double rating, int numberOfDownloads, DateTime dateDownloaded)
        {
            Name = name;
            Artist = artist;
            SongType = songType;
            Rating = rating;
            NumberOfDownloads = numberOfDownloads;
            DateDownloaded = dateDownloaded;
        }
        public override string ToString()
        {
            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", Name, Artist, SongType,
Rating, NumberOfDownloads, DateDownloaded);
        }
    }
}
