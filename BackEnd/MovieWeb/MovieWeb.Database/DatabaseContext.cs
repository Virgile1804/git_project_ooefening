
using Microsoft.EntityFrameworkCore;
using MovieWeb.Database.Movie;
using NetFlow.Database.Episode;
using NetFlow.Database.User;

namespace MovieWeb.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ActorDatabase> actors { get; set; }
        public DbSet<MovieDatabase> movies { get; set; }
        public DbSet<UserDatabase> users { get; set; }
        public DbSet<EpisodeDatabase> episodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorDatabase>().ToTable("Actor");
            modelBuilder.Entity<MovieDatabase>().ToTable("Movie");
            modelBuilder.Entity<UserDatabase>().ToTable("User");
            modelBuilder.Entity<EpisodeDatabase>().ToTable("Episode");
           
        }
    }
}
