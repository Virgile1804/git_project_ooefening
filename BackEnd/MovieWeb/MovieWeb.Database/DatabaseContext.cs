
using Microsoft.EntityFrameworkCore;
using MovieWeb.Database.Movie;

namespace MovieWeb.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ActorDatabase> actors { get; set; }
        public DbSet<MovieDatabase> movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorDatabase>().ToTable("Actor");
            modelBuilder.Entity<MovieDatabase>().ToTable("Movie");
           
        }
    }
}
