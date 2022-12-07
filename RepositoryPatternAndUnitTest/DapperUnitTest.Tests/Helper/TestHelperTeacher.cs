namespace DapperUnitTest.Tests.Data
{
    using DapperCRUD.Domain.Entities;
    public class TestHelperTeacher
    {
        public List<Teacher> GetTeacher()
        {
            List<Teacher> output = new List<Teacher>
            {
                new Teacher
                {
                    teacherID = 4,
                    teacherName = "Manish",
                    teacherClass = "4th",
                    teacherSubject = "Math"
                },
                new Teacher
                {
                    teacherID = 5,
                    teacherName = "Yogita",
                    teacherClass = "8th",
                    teacherSubject = "Bio"
                },
                new Teacher
                {
                    teacherID = 6,
                    teacherName = "Nalini",
                    teacherClass = "9th",
                    teacherSubject = "Marathi"
                }
            };
            return output;
        }
    }
}
