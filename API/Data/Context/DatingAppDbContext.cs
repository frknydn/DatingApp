using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class DatingAppDbContext : DbContext
    {
        public DatingAppDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<AppUser> Users { get; set; }
    }
}