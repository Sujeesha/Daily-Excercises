﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAssignmentreq2
{
    internal class Mail
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set
            {
                _to = value;
            }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
            }
        }
        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private double _size;
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Mail()
        {

        }
        public Mail(long id, string from, string to, string subject, string content, DateTime receivedDate, double size)
        {
            Id = id;
            From = from;
            To = to;
            Subject = subject;
            Content = content;
            ReceivedDate = receivedDate;
            Size = size;
        }
        //public override string ToString()
        //{
          //  return string.Format("Id:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:" +
           //     ReceivedDate.ToString("dd-MM-yyyy", null), Size.ToString("0.0"));

       // }

        public static Mail CreateMail(string detail)
        {
            string[] s = detail.Split(',');
            DateTime dt = DateTime.ParseExact(s[5], "dd-mm-yyyy", null);
            Mail m1 = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], dt, double.Parse(s[6]));
            return m1;

        }
        public override string ToString()
        {
            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15} {6,15}", Id, From,
                    To, Subject, Content, ReceivedDate, Size);
        }
    }
}
