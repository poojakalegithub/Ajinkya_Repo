namespace EntityFrameworkCRUD.Controllers
{
    using EntityFrameworkCRUD.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.Data.SqlClient;

    [Route("api/[controller]")]
    [ApiController]
    public class StudentDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public StudentDataController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetAllStudent")]
        public Response GetAllStudent()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("StudentDataConnection").ToString());
            Response response = new Response();
            StudentDataOperation studentDataOperation = new StudentDataOperation();
            response = studentDataOperation.GetAllStudent(connection);
            return response;
        }

        [HttpPost]
        [Route("ADDStudent")]

        public Response AddStudent(StudentData studentData)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("StudentDataConnection").ToString());
            Response response = new Response();
            StudentDataOperation studentDataOperation = new StudentDataOperation();
            response = studentDataOperation.ADDStudent(connection, studentData);
            return response;
        }

        [HttpPut]
        [Route("UpdateStudent")]
        public Response UpdateStudent(StudentData studentData)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("StudentDataConnection").ToString());
            Response response = new Response();
            StudentDataOperation studentDataOperation = new StudentDataOperation();
            response = studentDataOperation.UpdateStudent(connection, studentData);
            return response;
        }


        [HttpDelete]
        [Route("DeleteStudent/{studentID}")]
        public Response DeleteStudent(int studentID)
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("StudentDataConnection").ToString());
            Response response = new Response();
            StudentDataOperation studentDataOperation = new StudentDataOperation();
            response = studentDataOperation.DeleteStudent(connection, studentID);
            return response;
        }
    }
}

