﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReq5
{
    internal class Song
    {
        private string _name;
        public string Name
        {
            get { return _name; }
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
            }
        }

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
        //sorted dictionary from list
        public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            //define sorted dictionary
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            //sorting using key
            foreach (var item in list)
            {
                if (sd.ContainsKey(item.SongType))
                {
                    sd[item.SongType]++;
                }
                else
                {
                    sd.Add(item.SongType, 1);
                }
             
            }
            return sd;
        }
    }
}
