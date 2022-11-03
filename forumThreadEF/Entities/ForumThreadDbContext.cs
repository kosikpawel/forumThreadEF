using Microsoft.EntityFrameworkCore;

namespace forumThreadEF.Entities
{
    public class ForumThreadDbContext : DbContext
    {
        public ForumThreadDbContext(DbContextOptions<ForumThreadDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

    }
}
