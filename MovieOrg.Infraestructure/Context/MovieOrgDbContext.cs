using Microsoft.EntityFrameworkCore;
using MovieOrg.Domain.Entities;

namespace MovieOrg.Infraestructure.Context
{
    public class MovieOrgDbContext : DbContext
    {
        public MovieOrgDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql();
        }
    }
}
