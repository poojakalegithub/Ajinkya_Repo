namespace DapperCRUD.api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using DapperCRUD.Domain.Entities;
    using DapperCRUD.Domain.Interfaces;
    using System.Data.SqlClient;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using System.Data;

    public class TeacherController : BaseApiController
    {
        private readonly ITeacherRepository<Teacher> _repository;
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ITeacherRepository<Teacher> teacherRepository, ILogger<TeacherController> logger)
        {
            _repository= teacherRepository;
            _logger = logger;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Standard, Administrator")]
        public async Task<IActionResult> GetAllTeacher()
        {
            _logger.LogInformation("Getting Teacher details...");
            var apiResponse = new ApiResponse<List<Teacher>>();

            try
            {
                var data = await _repository.GetAllTeacher();
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
        public async Task<IActionResult> GetTeacherById(int id)
        {
            _logger.LogInformation("Getting Teacher details by ID...");
            var apiResponse = new ApiResponse<Teacher>();

            try
            {
                var data = await _repository.GetTeacherById(id);
                apiResponse.Success = true;
                apiResponse.Result = data;
            }
            catch (SqlException ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                _logger.LogError("SQL Exeption:", ex);
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
        public async Task<IActionResult> AddTeacher(Teacher teacher)
        {
            _logger.LogInformation("Adding Teacher...");
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _repository.AddTeacher(teacher);
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
        public async Task<IActionResult> UpdateTeacher(Teacher teacher)
        {
            _logger.LogInformation("Updating Teacher...");
            var apiResponse = new ApiResponse<string>();
            try
            {
                var data = await _repository.UpdateTeacher(teacher);
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
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            _logger.LogInformation("Deleting Teacher...");
            var apiResponse = new ApiResponse<string>();

            try
            {
                var data = await _repository.DeleteTeacher(id);
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

