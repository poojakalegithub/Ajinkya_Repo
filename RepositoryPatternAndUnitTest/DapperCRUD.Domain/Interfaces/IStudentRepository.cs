namespace DapperCRUD.Domain.Interfaces
{
    public interface IStudentRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllStudent();
        Task<T> GetStudentById(int id);
        Task<string> AddStudent(T entity);
        Task<string> UpdateStudent(T entity);
        Task<string> DeleteStudent(int id);
    }
}
