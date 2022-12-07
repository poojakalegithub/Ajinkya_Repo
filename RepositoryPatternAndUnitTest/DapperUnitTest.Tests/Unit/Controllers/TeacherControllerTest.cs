namespace DapperUnitTest.Tests.Unit.Controllers
{
    using DapperCRUD.api.Controllers;
    using DapperCRUD.Domain.Entities;
    using DapperCRUD.Domain.Interfaces;
    using DapperUnitTest.Tests.Data;
    using FluentAssertions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Moq;
    using Xunit;
    public class TeacherControllerTest : TestHelperTeacher
    {
        private readonly Mock<ITeacherRepository<Teacher>> mockRepository;
        private readonly Mock<ILogger<TeacherController>> logger;
        private readonly TeacherController controller;

        public TeacherControllerTest()
        {
            mockRepository = new Mock<ITeacherRepository<Teacher>>();
            logger = new Mock<ILogger<TeacherController>>();
            controller = new TeacherController(mockRepository.Object,logger.Object);

        }

        [Fact]
        public async Task GetAllTeacher_ListOfTeacher_StudentExistsInRepo()
        {
            //arrange
            var students = GetTeacher();
            mockRepository.Setup(repo => repo.GetAllTeacher()).ReturnsAsync(students);

            //act
            var Result = await controller.GetAllTeacher();
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public async Task GetTeacherById_GetTeacherObject_TeacherwithSpecificeIdExists()
        {
            //arrange
            var students = GetTeacher();
            var firstStudent = students[0];
            mockRepository.Setup(repo => repo.GetTeacherById((int)1)).ReturnsAsync(firstStudent);

            //act
            var Result = await controller.GetTeacherById((int)1);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //Assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public async Task AddTeacher_MustCreatedTeacher_PassingTeacherObjectToCreate()
        {
            //arrange
            var teachers = GetTeacher();
            var newTeacher = teachers[0];
            mockRepository.Setup(repo => repo.AddTeacher(newTeacher));

            //act
            var Result = await controller.AddTeacher(newTeacher);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task UpdateTeacher_MustUpdateTeacher_PassingTeachertObjectToUpdate()
        {
            //arrange
            var teachers = GetTeacher();
            var newTeacher = teachers[0];
            mockRepository.Setup(repo => repo.UpdateTeacher(newTeacher));

            //act
            var Result = await controller.UpdateTeacher(newTeacher);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task DeleteTeacher_MustDeleteTeacher_PassingTeacherObjectToDelete()
        {
            //arrange
            var teachers = GetTeacher();
            var firstStudent = teachers[0];
            mockRepository.Setup(repo => repo.DeleteTeacher((int)1));

            //act
            var Result = await controller.DeleteTeacher((int)1);
            OkObjectResult result = Assert.IsType<OkObjectResult>(Result);

            //assert
            result.GetType().Should().Be(typeof(OkObjectResult));
            result.StatusCode.Should().Be(200);
        }
    }
}
