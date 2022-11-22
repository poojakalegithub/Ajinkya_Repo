namespace EntityFrameworkCRUD.Models
{
    using System.Data.SqlClient;
    using System.Data;
    public class StudentDataOperation
    {
        public Response GetAllStudent(SqlConnection connection)
        {
            Response response = new Response();
            SqlDataAdapter studentAdapter = new SqlDataAdapter("SELECT * FROM StudentData", connection);
            DataTable studentTable = new DataTable();
            List<StudentData> listStudent = new List<StudentData>();
            studentAdapter.Fill(studentTable);

            if (studentTable.Rows.Count > 0)
            {
                for (int i = 0; i < studentTable.Rows.Count; i++)
                {
                    StudentData studentData = new StudentData();
                    studentData.studentName = Convert.ToString(studentTable.Rows[i]["studentName"]);
                    studentData.studentRollno = Convert.ToInt32(studentTable.Rows[i]["studentRollno"]);
                    studentData.studentPercentage = Convert.ToString(studentTable.Rows[i]["studentPercentage"]);
                    listStudent.Add(studentData);
                }

            }
            if (listStudent.Count > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "OK Data found.";
                response.listStudent = listStudent;
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data found.";
                response.listStudent = null;
            }
            return response;
        }

        public Response ADDStudent(SqlConnection connection, StudentData studentData)
        {
            Response response = new Response();
            SqlCommand studentCommand = new SqlCommand("INSERT INTO StudentData(studentName, studentRollno, studentPercentage) VALUES('" + studentData.studentName + "','" + studentData.studentRollno + "','" + studentData.studentPercentage + "')", connection);
            connection.Open();
            int i = studentCommand.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data added.";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data added.";

            }
            return response;
        }

        public Response UpdateStudent(SqlConnection connection, StudentData studentData)
        {
            Response response = new Response();
            SqlCommand studentCommand = new SqlCommand("UPDATE StudentData SET studentName = '" + studentData.studentName + "', studentRollno = '" + studentData.studentRollno + "', studentPercentage = '" + studentData.studentPercentage + "' WHERE studentRollno = '" + studentData.studentRollno + "'", connection);
            connection.Open();
            int i = studentCommand.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Data updated.";
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "No Data updated";

            }
            return response;
        }

        public Response DeleteStudent(SqlConnection connection, int studentID)
        {
            Response response = new Response();
            SqlCommand studentCommand = new SqlCommand("DELETE FROM studentData WHERE studentID = '" + studentID + "'", connection);
            connection.Open();
            int i = studentCommand.ExecuteNonQuery();
            connection.Close();

            if (i > 0)
            {
                response.StatusCode = 200;
                response.StatusMessage = "Student Deleted.";
            }

            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Student not deleted";
            }
            return response;
        }
    }
}
