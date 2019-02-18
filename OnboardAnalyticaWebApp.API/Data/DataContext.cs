using Microsoft.EntityFrameworkCore;
using OnboardAnalyticaWebApp.API.Models;

namespace OnboardAnalyticaWebApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values {get; set;}
        public DbSet<User> Users {get; set;}
    }
}