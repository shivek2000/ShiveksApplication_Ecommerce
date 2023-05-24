using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShiveksApplication_Ecommerce.Models;

namespace ShiveksApplication_Ecommerce.Data
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> Options):base(Options)
        {

        }

        // for many to many relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId

            });
            //define the relationship between the Actor_movie to movie
            modelBuilder.Entity<Actor_movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m =>
               m.ActorId);

            modelBuilder.Entity<Actor_movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m =>
              m.MovieId);



            //>().HasKey(am => new {am.ac });
            base.OnModelCreating(modelBuilder);



        }
        //define the table names for models

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor_movie> Actor_Movie { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
