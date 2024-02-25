namespace CheckDesk_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }
        public string Obj_type { get; set; }
        public string password { get; set; }

    }
}
