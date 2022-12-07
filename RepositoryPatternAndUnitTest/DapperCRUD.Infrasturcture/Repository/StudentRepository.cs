namespace DapperCRUD.Infrasturcture.Repository
{
    using DapperCRUD.Domain.Interfaces;
    using DapperCRUD.Domain.Entities;
    using Dapper;
    using Microsoft.Extensions.Configuration;
    using System.Data.SqlClient;
    using System.Data;
    using System.Collections.Generic;

    public class StudentRepository : IStudentRepository<Student>
    {
        private readonly IConfiguration configuration;
        public StudentRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<IReadOnlyList<Student>> GetAllStudent()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {

                var result = await connection.QueryAsync<Student>("spGetAllStudent");
                return result.ToList();
            }
        }

        public async Task<Student> GetStudentById(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {

                var result = await connection.QuerySingleOrDefaultAsync<Student>("spGetByIDStudent @studentId", new { studentId = id });
                return result;
            }
        }

        public async Task<string> AddStudent(Student entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {

                var result = await connection.ExecuteAsync("spAddStudent @studentName, @studentClass, @studentSubject", entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateStudent(Student entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                var result = await connection.ExecuteAsync("spUpdateStudent @studentID, @studentName, @studentClass, @studentSubject", entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteStudent(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                var result = await connection.ExecuteAsync("spDeleteStudent @studentId", new { studentId = id });
                return result.ToString();
            }
        }
    }
}


