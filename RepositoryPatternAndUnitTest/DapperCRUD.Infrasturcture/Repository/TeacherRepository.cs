namespace DapperCRUD.Infrasturcture.Repository
{
    using DapperCRUD.Domain.Interfaces;
    using DapperCRUD.Domain.Entities;
    using Dapper;
    using Microsoft.Extensions.Configuration;
    using System.Data.SqlClient;
    using System.Data;
    using System.Collections.Generic;

    public class TeacherRepository : ITeacherRepository<Teacher>
    {
        private readonly IConfiguration configuration;
        public TeacherRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<IReadOnlyList<Teacher>> GetAllTeacher()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Teacher>("spGetAllTeacher");
                return result.ToList();
            }
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Teacher>("spGetByIDTeacher @teacherId", new { teacherId = id });
                return result;
            }
        }

        public async Task<string> AddTeacher(Teacher entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("spAddTeacher @teacherName, @teacherClass, @teacherSubject", entity);
                return result.ToString();
            }
        }

        public async Task<string> UpdateTeacher(Teacher entity)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("spUpdateTeacher @teacherID, @teacherName, @teacherClass, @teacherSubject", entity);
                return result.ToString();
            }
        }

        public async Task<string> DeleteTeacher(int id)
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync("spDeleteTeacher @teacherId", new { teacherId = id });
                return result.ToString();
            }
        }
    }
}


