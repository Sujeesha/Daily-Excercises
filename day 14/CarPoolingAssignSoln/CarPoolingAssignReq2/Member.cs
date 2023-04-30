using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq2
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
        private List<MemberCar> _carList = new List<MemberCar>();

        public List<MemberCar> CarList
        {
            get { return _carList; }
            set { _carList = value; }
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
        //public static FindMember(long id)
        //{
        //    foreach(var item in )

        //}
        public static Member FindMember(ArrayList list, long _id)
        {
            foreach (Member member in list)
            {
                if (member.Id == _id)
                {
                    return member;
                }
            }
            return null;
        }
    }
}
