using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class StudentData
    {
        int    Student_Id, Student_Sem;
        string Student_Dept, Student_Name;
        
        public override string ToString()
        {
            return Student_Id + "\t " + Student_Name + "\t " +
                Student_Dept + "\t " + Student_Sem;
        }
 
        public void Display()
        {
            List<StudentData> student = new List<StudentData>()
            {

                new StudentData{ Student_Id = 101, Student_Name = "Ajinkya", Student_Dept = "CSE", Student_Sem = 2 },
                new StudentData{ Student_Id = 102, Student_Name = "Ganesh ", Student_Dept = "IT ", Student_Sem = 1 },
                new StudentData{ Student_Id = 103, Student_Name = "Sudanshu",Student_Dept = "Mech", Student_Sem = 4},
            };

            
            IEnumerable<StudentData> Query = from Student in student select Student;

            Console.WriteLine("ID \t Name \t Department \t Semester");
            foreach (StudentData e in Query)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}



