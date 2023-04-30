using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingAssignReq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            ArrayList carlist = new ArrayList();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1)Add a Member");
                Console.WriteLine("2)Add a Car");
                Console.WriteLine("3) Assign Car to Member (Assume valid data is supplied)");
                Console.WriteLine("4) Cars Owned");
                Console.WriteLine("5) Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //ArrayList list = new ArrayList();
                        Console.WriteLine("Id:");
                        long id = long.Parse(Console.ReadLine());
                        Console.WriteLine("first name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("last name:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("contact number:");
                        string contactNumber = Console.ReadLine();
                        Console.WriteLine("licence number");
                        string licenceNumber = Console.ReadLine();
                        Console.WriteLine("licence start date:");
                        DateTime licenceStartDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("licence expiry date:");
                        DateTime licenceExpiryDate = DateTime.Parse(Console.ReadLine());
                        Member m = new Member(id, firstName, lastName, email, contactNumber, licenceNumber, licenceStartDate, licenceExpiryDate);
                        list.Add(m);
                        break;
                    case 2:
                        Console.WriteLine("Id:");
                        long carId=long.Parse(Console.ReadLine());
                        Console.WriteLine("Name:");
                        string Name=Console.ReadLine();
                        Console.WriteLine("Model");
                        string Model=Console.ReadLine();
                        Console.WriteLine("Make Year:");
                        int MakeYear=int.Parse(Console.ReadLine());
                        Console.WriteLine("Company:");
                        string Company=Console.ReadLine();
                        Console.WriteLine("Comfort Level:");
                        int ComfortLevel = int.Parse(Console.ReadLine());
                        Car car = new Car(carId,Name,Model,MakeYear,Company,ComfortLevel);
                        carlist.Add(car);   

                        break;
                    case 3:
                        Console.WriteLine("Member Id:");
                        long memberId=long.Parse(Console.ReadLine());   
                        Console.WriteLine("Car Id:");
                        long carIdForAssignment=long.Parse(Console.ReadLine());
                        Console.WriteLine("Car Registration Number");
                        string CarRegistrationNumber=Console.ReadLine();
                        Console.WriteLine("Car Color");
                        string carColor=Console.ReadLine();
                        Member memberForAssignment = Member.FindMember(list, memberId);
                        Car carForAssignment = Car.FindCar(carlist, carIdForAssignment);
                        if(memberForAssignment!= null && carForAssignment != null)
                        {
                            MemberCar membercar = new MemberCar(memberForAssignment, carForAssignment, CarRegistrationNumber, carColor); 
                            memberForAssignment.CarList.Add(membercar);
                            Console.WriteLine("Car assigned successfully");

                        }
                        else
                        {
                            Console.WriteLine("Invalid member id or car id");
                        }
                        break;
                    case 4:
                        Console.WriteLine("member id:");
                        long memberidforcarowned=long.Parse(Console.ReadLine());
                        Member memberforcarowned = Member.FindMember(list, memberidforcarowned);
                        if(memberforcarowned != null)
                        {
                            Console.WriteLine("Number of cars owned: " + memberforcarowned.FirstName + " " + memberforcarowned.LastName + ": " + memberforcarowned.CarList.Count);
                        }
                        break;
                    case 5:
                        break;
                       
                }
            }    }
    }
}
