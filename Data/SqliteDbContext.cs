using LatihanApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LatihanApi.Data
{
    public class SqliteDbContext : DbContext
    {
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}