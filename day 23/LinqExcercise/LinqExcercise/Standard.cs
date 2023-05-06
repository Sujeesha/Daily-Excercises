using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercise
{
    internal class Standard
    {
        private int _standardId;
        public int StandardId
        {
            get { return _standardId; }
            set { _standardId = value; }
        }
        private string _standardName;   
        public string StandardName
        {
            get { return _standardName; }
            set { _standardName = value; }
        }
        public Standard()
        {

        }
        public Standard(int standardId, string standardName)
        {
            StandardId = standardId;
            StandardName = standardName;
        }   
    }
}
