namespace MovieManagementDataAccess.Context;
using MovieManagementDomain.Entities;
using Microsoft.EntityFrameworkCore;

public class MovieManagementDbContext: DbContext
{
    public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options): base(options){}
    
        public DbSet <Actor> Actors { get; set; }
        public DbSet <Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet <Biography> Biographies { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(
            new Actor{Id = 1, firstName = "Cilian", lastName = "Murphy"},
            new Actor{Id = 2, firstName = "Scarlett", lastName = "Johansson"},
            new Actor{Id = 3, firstName = "Daniel", lastName = "Radcliffe"}
        );

        modelBuilder.Entity<Movie>().HasData(
            new Movie{Id = 1, movieName="Oppenheimer", movieDescription = "Cinematic Nuclear Explosion", ActorId = 1},
            new Movie{Id = 2, movieName="Interstellar", movieDescription = "Cinematic Universe Exploration", ActorId = 1},
            new Movie{Id = 3, movieName="Black Widow", movieDescription = "Blood Sister Battle", ActorId = 2},
            new Movie{Id = 4, movieName="Harry Potter", movieDescription = "Epic Gothic Magic", ActorId = 3}
        );
    }
}