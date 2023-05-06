using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercise
{
    internal class Student
    {
        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
        private string _studentName;
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        private int _age;
        public int Age{
            get { return _age; }
            set { _age = value; }

        }
        private int _standardId;
        public int StandardId
        {
            get { return _standardId; } 
            set { _standardId = value; }    
        }
        public Student()
        {

        }
        public Student(int studentId, string studentName, int age, int standardId)
        {
            _studentId = studentId;
           
            _studentName = studentName;
            
            _age = age;
           
            _standardId = standardId;
            
        }   
    }
}
