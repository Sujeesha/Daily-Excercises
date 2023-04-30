using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq6
{
    internal class Member
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _contactNumber;
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        private string _licenceNumber;
        public string LicenceNumber
        {
            get { return _licenceNumber; }
            set { _licenceNumber = value; }
        }
        private DateTime _licenceStartDate;
        public DateTime LicenceStartDate
        {
            get { return _licenceStartDate; }
            set { _licenceStartDate = value; }
        }

        private DateTime _licenceExpiryDate;
        public DateTime LicenceExpiryDate
        {
            get { return _licenceExpiryDate; }
            set { _licenceExpiryDate = value; }
        }
        public Member()
        {

        }
        public Member(long id, string firstName, string lastName, string email, string contactNumber, string licenceNumber, DateTime licenceStartDate, DateTime licenceExpiryDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ContactNumber = contactNumber;
            LicenceNumber = licenceNumber;
            LicenceStartDate = licenceStartDate;
            LicenceExpiryDate = licenceExpiryDate;
        }
        public override string ToString()
        {
            return string.Format("Name:{0},{1}\n Member contact details:{2},{3}", _firstName, _lastName, _contactNumber, _email);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}