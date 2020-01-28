using DatingApp.api.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) :base(options) { }

        public DataContext(DbContextOptions options) : base(options){ }
        public DbSet<Value> Values { get; set;}
    }
}