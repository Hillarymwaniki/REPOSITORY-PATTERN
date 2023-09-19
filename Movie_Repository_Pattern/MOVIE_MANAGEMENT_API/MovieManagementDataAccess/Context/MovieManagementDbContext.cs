namespace MovieManagementDataAccess.Context;
using MovieManagementDomain.Entities;

public class MovieManagementDbContext: DbContext
{
    public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options): base(options)
    {
        public DbSet <Actor> Actors { get; set; }
        public DbSet <Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet <Biography> Biographies { get; set; }
    }
}