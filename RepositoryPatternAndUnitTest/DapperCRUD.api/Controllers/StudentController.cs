namespace DapperCRUD.api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using DapperCRUD.Domain.Entities;
    using DapperCRUD.Domain.Interfaces;
    using System.Data.SqlClient;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using System.Data;

    public class StudentController : BaseApiController
    {
        
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentRepository<Student> _repository;

        public StudentController(IStudentRepository<Student> studentRepository,ILogger<StudentController> logger)
        {
            _logger = logger;
            _repository = studentRepository;
           
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Standard, Administrator")]
        public async Task<IActionResult> GetAllStudent()
        {
            _logger.LogInformation("Getting Student details...");
            var apiResponse = new ApiResponse<List<Student>>();
           
            try
            {
                var data = await _repository.GetAllStudent();
                apiResponse.Success = true;
                apiResponse.Result = data.ToList();
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            return Ok(apiResponse);
        }

        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Standard, Administrator")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            _logger.LogInformation("Getting Student details by ID...");
            var apiResponse = new ApiResponse<Student>();

            try
            {
                var data = await _repository.GetStudentById(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            return Ok(apiResponse);
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> AddStudent(Student student)
        {
            _logger.LogInformation("Adding Student...");
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _repository.AddStudent(student);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            return Ok(apiResponse);
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> UpdateStudent(Student student)
        {
            _logger.LogInformation("Updating Student...");
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _repository.UpdateStudent(student);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            return Ok(apiResponse);
        }

        [HttpDelete]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            _logger.LogInformation("Deleting Student...");
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _repository.DeleteStudent(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exception:", ex);
            }
            return Ok(apiResponse);
        }
    }
}

