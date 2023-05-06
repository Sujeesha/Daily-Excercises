using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
            new Student(){StudentId=1,StudentName="John",Age=18,StandardId=1},
            new Student(){StudentId=2,StudentName="Steve",Age=21,StandardId=1},
            new Student(){StudentId=3,StudentName="Bill",Age=18,StandardId=2},
            new Student(){StudentId=4,StudentName="Ram",Age=20,StandardId=2},
            new Student(){StudentId=5,StudentName="Bon",Age=21}
            };
            IList<Standard> standardList = new List<Standard>()
            {
                new Standard() { StandardId = 1, StandardName = "Standard 1" },
            new Standard() { StandardId = 2, StandardName = "Standard 2" },
            new Standard() { StandardId = 3, StandardName = "Standard 3" }
            };
            //Multiple Select and where operator
            var studentNames =studentList.Where(s=>s.Age>18).Select(s=>s)
                                         .Where (st=>st.StandardId>0).Select(s=>s.StudentName);
            foreach (var student in studentNames)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------");

            var teenStudentsName=studentList.Where(s=>s.Age>12&&s.Age<20).Select(s=>s.StudentName);
            foreach(var teenstudent in teenStudentsName)
            {
                Console.WriteLine(teenstudent); 
            }
            //The following query returns Enumerable of anonymous object that has
            //only StudentName property:
            var teenStudentName=from s in studentList where s.Age>12 &&s.Age<20
                                select new { StudentName = s.StudentName };
            teenStudentName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
            Console.WriteLine("-----------------------");
            //Group By
            //The following query returns list students group by StandardID:
            var StudentsGroupByStandard=from s in studentList group s by s.StandardId into sg
                                        orderby sg.Key

        }
    }
}
