namespace DapperCRUD.Infrasturcture.Repository
{
    using DapperCRUD.Domain.Entities;
    using DapperCRUD.Domain.Interfaces;
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IStudentRepository<Student> studentRepository, ITeacherRepository<Teacher> teacherRepository)
        {
            Students = studentRepository;
            Teachers = teacherRepository;
        }

        public IStudentRepository<Student> Students { get; set; }
        public ITeacherRepository<Teacher> Teachers { get; set; }
    }
}
