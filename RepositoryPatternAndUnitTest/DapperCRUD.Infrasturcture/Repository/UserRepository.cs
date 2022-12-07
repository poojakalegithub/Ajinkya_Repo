namespace DapperCRUD.Infrasturcture.Repository
{
    using DapperCRUD.Domain.Entities;
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "ajinkya_admin", EmailAddress = "ajinkya.admin@email.com", Password = "password", GivenName = "Ajinkya", Surname = "Sonawane", Role = "Administrator" },
            new() { Username = "ganesh_standard", EmailAddress = "ganesh.standard@email.com", Password = "password", GivenName = "Ganesh", Surname = "Hire", Role = "Standard" },
        };
    }
}
