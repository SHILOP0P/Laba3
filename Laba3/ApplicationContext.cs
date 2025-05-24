using Laba3.Models;
using Microsoft.EntityFrameworkCore;

namespace Laba3
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Director> Directors => Set<Director>();
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Actor> Actors => Set<Actor>();
        public DbSet<MovieActor> MovieActors => Set<MovieActor>();
        public ApplicationContext(DbContextOptions options) => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
