using Microsoft.EntityFrameworkCore;
using myFirstApi.Etities;
using System.Security.Cryptography.X509Certificates;

namespace myFirstApi.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
 
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Role>Roles { get; set; }
    }
}
