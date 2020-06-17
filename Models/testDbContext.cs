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

        // one-to-many
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostFull> PostsFull { get; set; }

        // end one-to-many

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Blog>()
            //     .HasMany(b => b.Posts)
            //     .WithOne(p => p.Blog);

            // modelBuilder.Entity<Post>()
            //     .HasOne(p => p.Blog)
            //     .WithMany(b => b.Posts);

            modelBuilder.Entity<PostFull>().HasNoKey();
        }
    }
}