using CheckDesk_API.Models;

namespace CheckDesk_API.Services
{
    public class UserService
    {

        static List<User> Users { get; }
        static int nextId = 3;
        static UserService()
        {
            Users = new List<User>
        {
            new User { Id = 1, Name = "Pierre" },
            new User { Id = 2, Name = "Diego" }
        };
        }
    }
}
