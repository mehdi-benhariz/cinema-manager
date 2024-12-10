using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actor_Movie>().HasKey(am =>
            new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movie).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movie).HasForeignKey(m => m.ActorId);


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cinema>().HasData(
            new Cinema { CinemaId = 1, Name = "Cinema 1", Logo = "logo1.png", Description = "Description 1" },
            new Cinema { CinemaId = 2, Name = "Cinema 2", Logo = "logo2.png", Description = "Description 2" },
            new Cinema { CinemaId = 3, Name = "Cinema 3", Logo = "logo3.png", Description = "Description 3" }
        );
        }
        public DbSet<Actor> Actors {get ; set ;}
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


    }
}
