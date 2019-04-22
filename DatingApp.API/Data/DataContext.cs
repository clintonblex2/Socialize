using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // DataContext is a derived class of DbContext
    public class DataContext : DbContext
    {
        // create a constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        // tell entity framework about our entity i.e Value model class
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}