namespace CheckDesk_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Id_parc { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Role { get; set; }
        public string Obj_type { get; set; }
        public string mdp { get; set; }

    }
}
