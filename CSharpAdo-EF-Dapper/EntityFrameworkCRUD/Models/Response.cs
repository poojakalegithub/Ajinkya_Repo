namespace EntityFrameworkCRUD.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public StudentData studentData { get; set; }
        public List<StudentData> listStudent { get; set; }
    }
}
