using DapperCRUD.Domain.Entities;
namespace DapperCRUD.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IStudentRepository<Student> Students { get; }
        ITeacherRepository<Teacher> Teachers { get; }
    }
}
