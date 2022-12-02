namespace DapperUnitTest.Tests.Data
{
    using DapperCRUD.Domain.Entities;
    using System.Data.SqlClient;
    using System.Runtime.Serialization;

    public class TestHelperStudent
    {
        public List<Student> GetStudent()
        {
            List<Student> output = new List<Student>
            {
                new Student
                {
                    studentID = 4,
                    studentName = "Manish",
                    studentClass = "4th",
                    studentSubject = "Math"
                },
                new Student
                {
                    studentID = 5,
                    studentName = "Yogita",
                    studentClass = "8th",
                    studentSubject = "Bio"
                },
                new Student
                {
                    studentID = 6,
                    studentName = "Nalini",
                    studentClass = "9th",
                    studentSubject = "Marathi"
                }
            };
            return output;
        }
    }
}
