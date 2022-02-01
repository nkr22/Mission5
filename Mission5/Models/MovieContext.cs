using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //leave blank for now
        }
    
        public DbSet<FormResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }


        //seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category{CategoryId = 1, CategoryName = "Adventure"},
                     new Category { CategoryId = 2, CategoryName = "Family" },
                      new Category { CategoryId = 3, CategoryName = "Romance" },
                       new Category { CategoryId = 4, CategoryName = "Comedy" },
                        new Category { CategoryId = 5, CategoryName = "Horror" },
                         new Category { CategoryId = 6, CategoryName = "Drama" },
                          new Category { CategoryId = 7, CategoryName = "Musical" }
                ) ;

            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    MovieId = 1,
                    CategoryId = 3,
                    Title = "13 Going on 30",
                    Year = "2004",
                    Director = "Gary Winick",
                    Rating = "PG-13",
                    Edited = "true",
                    LentTo = "Cami",
                    Notes = "My favorite romcom"
                },
                new FormResponse
                {
                    MovieId = 2,
                    CategoryId = 1,
                    Title = "The Avengers",
                    Year = "2012",
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = "false",
                    LentTo = "Spencer",
                    Notes = "So funny"
                },
                new FormResponse
                {
                    MovieId = 3,
                    CategoryId = 2,
                    Title = "Tangled",
                    Year = "2010",
                    Director = "Nathan Greno",
                    Rating = "PG",
                    Edited = "false",
                    LentTo = "Elena",
                    Notes = "Best Princess Movie"
                }
               );
        }


    }
}
