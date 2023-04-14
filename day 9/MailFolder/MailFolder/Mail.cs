using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolder
{
    internal class Mail
    {
        //fiels
        private long _id;
        public long Id
        {
            get { return _id; } 
            set { _id = value; }    
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
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
            set { _content = value; }
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
        public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate,double size)
        {
            _id = id;
            _to = to;
            _from = from;
            _subject = subject;
            _content = content;
            _receivedDate = receivedDate;
            _size = size;   
            
        }
        public override string ToString()
        {
            //return $"Id: {Id} \n To: {To} \n From: {From} \n Subject:{Subject} \n Content: {Content} \n ReceivedDate: {ReceivedDate} \n Size: {Size}";
            return string.Format("Id:{0}\nTo:{1}\nFrom:{2}\nSubject:{3}\nContent:" +
                "{4}\nReceivedDate{5}\nSize:{6}",Id,To,From,Subject,Content,
                ReceivedDate.ToString("dd-MM-yyyy",null),Size.ToString("0.0"));

        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
