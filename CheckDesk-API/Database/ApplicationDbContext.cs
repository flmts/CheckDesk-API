using CheckDesk_API.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace CheckDesk_API.Database
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        
        public DbSet<User> user { get; set; }
        public DbSet<CheckDesk_API.Models.Parc> Parc { get; set; } = default!;
        public DbSet<CheckDesk_API.Models.Poste> Poste { get; set; } = default!;
        public DbSet<CheckDesk_API.Models.Salle> Salle { get; set; } = default!;
    }
}
