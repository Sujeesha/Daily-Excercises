using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingReq3
{
    internal class Car
    {
        private string _regnum;
        public string Regnum
        {
            get { return _regnum; }
            set { _regnum = value; }
        }
        private DateTime _licdt;
        public DateTime Licdt
        {
            get { return _licdt; }
            set { _licdt = value; }
        }
        public Car() { }
        public Car(string regnum, DateTime licdt)
        {
            Regnum = regnum;
            Licdt = licdt;
        }
        public static bool ValidCar(string _regnum)
        {
            string pattern = "^[A-Z]{2}[ -][0-9]{1,2}(?: [A-Z])?(?: [A-Z]*)? [0-9]{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(pattern, _regnum);
        }
        public static string CnvtCar(string _regnum)
        {
            return _regnum.Replace('@', '-').Replace('*', '-').ToUpper();
        }
        public static bool ValidLic(DateTime _licdt)
        {
            DateTime currentDate = DateTime.Now;
            DateTime expiryDate = _licdt.AddYears(10);
            return currentDate > expiryDate;
        }
    }
}

