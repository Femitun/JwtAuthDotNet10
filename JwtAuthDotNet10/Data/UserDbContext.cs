using JwtAuthDotNet10.Entities;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDotNet10.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
