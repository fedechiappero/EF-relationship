using Microsoft.EntityFrameworkCore;
using testDotnet.Models;

namespace testDotnet.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        // one-to-many
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        // end one-to-many

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Blog)
                .WithMany(b => b.Posts);
        }
    }
}