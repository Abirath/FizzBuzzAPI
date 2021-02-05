using Microsoft.EntityFrameworkCore;

namespace FizzBuzzAPI.Models
{
    public class FizzBuzzDBContext : DbContext
    {
        public DbSet<FizzBuzzStore> FizzBuzzStores { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.seed();
        }

        public FizzBuzzDBContext(DbContextOptions<FizzBuzzDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
