namespace DapperCRUD.Domain.Interfaces
{
    public interface ITeacherRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllTeacher();
        Task<T> GetTeacherById(int id);
        Task<string> AddTeacher(T entity);
        Task<string> UpdateTeacher(T entity);
        Task<string> DeleteTeacher(int id);

    }
}
