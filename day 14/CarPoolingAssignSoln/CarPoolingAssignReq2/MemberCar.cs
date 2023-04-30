using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq2
{
    internal class MemberCar
    {
        private long _id;
        public long Id { get { return _id; }
            set { _id = value; }
        }
        private Member _member;
        public Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
        private Car _car;
        public Car Car
        {
            get { return _car; }
            set { _car = value; }
        }


        private string _carRegistrationNumber;
        public string CarRegistrationNumber
        {
            get { return _carRegistrationNumber; }
            set { _carRegistrationNumber = value; }
        }
        private string _carColor;
        public string CarColor
        {
            get { return _carColor; }
            set { _carColor = value; }
        }
        public MemberCar() { }
        public MemberCar(long id, Member member, Car car, string carRegistrationNumber, string carColor)
        {
            _id = id;
            _member = member;
            _car = car;
            _carRegistrationNumber = carRegistrationNumber;
            _carColor = carColor;

        }
        public MemberCar(Member memberForAssignment, Car carForAssignment, string carRegistrationNumber, string carColor)
        {
            CarRegistrationNumber = carRegistrationNumber;
            CarColor = carColor;
        }

    }
    
}
