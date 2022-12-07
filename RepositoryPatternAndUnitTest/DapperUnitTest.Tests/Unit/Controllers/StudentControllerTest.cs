
namespace DapperUnitTest.Tests.Unit.Controllers
{
    using DapperCRUD.api.Controllers;
    using DapperCRUD.Domain.Entities;
    using DapperCRUD.Domain.Interfaces;
    using FluentAssertions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Xunit;
    using Moq;
    using DapperUnitTest.Tests.Data;
    public class StudentControllerTest : TestHelperStudent
    {
        private readonly Mock<IStudentRepository<Student>> mockRepository;
        private readonly Mock<ILogger<StudentController>> logger;
        private readonly StudentController controller;
        
        public StudentControllerTest()
        {
            mockRepository = new Mock<IStudentRepository<Student>>();
            logger = new Mock<ILogger<StudentController>>();
            controller = new StudentController(mockRepository.Object, logger.Object);
           
        }
           
        [Fact]
        public async Task GetAllStudent_ListOfStudent_StudentExistsInRepo()
        {
            //arrange
            var students = GetStudent();
            mockRepository.Setup(repo => repo.GetAllStudent()).ReturnsAsync(students);
            
            //act
            var Result = await controller.GetAllStudent();
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);           

        }

        [Fact]
        public async Task GetStudentById_StudentObject_StudentwithSpecificeIdExists()
        {
            //arrange
            var students = GetStudent();
            var firstStudent = students[0];
            mockRepository.Setup(repo => repo.GetStudentById((int)1)).ReturnsAsync(firstStudent);
            
            //act
            var Result = await controller.GetStudentById((int)1);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //Assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public async Task AddStudent_MustCreatedStudent_PassingStudentObjectToCreate()
        {
            //arrange
            var students = GetStudent();
            var newStudent = students[0];
            mockRepository.Setup(repo => repo.AddStudent(newStudent));

            //act
            var Result = await controller.AddStudent(newStudent);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task UpdateStudent_MustUpdateStudent_PassingStudentObjectToUpdate()
        {
            //arrange
            var students = GetStudent();
            var newStudent = students[0];
            mockRepository.Setup(repo => repo.UpdateStudent(newStudent));

            //act
            var Result = await controller.UpdateStudent(newStudent);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task DeleteStudent_MustDeleteStudent_PassingStudentObjectToDelete()
        {
            //arrange
            var students = GetStudent();
            var firstStudent = students[0];
            mockRepository.Setup(repo => repo.DeleteStudent((int)1));

            //act
            var Result = await controller.DeleteStudent((int)1);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);
        }
    }
}

