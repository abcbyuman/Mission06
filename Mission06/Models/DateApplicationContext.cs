using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class DateApplicationContext : DbContext
    {
        //Constructor
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Action" },
                    new Category { CategoryId = 2, CategoryName = "Comedy" },
                    new Category { CategoryId = 3, CategoryName = "Mystery" },
                    new Category { CategoryId = 4, CategoryName = "Horror" },
                    new Category { CategoryId = 5, CategoryName = "Other" }

                );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    CategoryId = 2,
                    Title = "Hot Rod",
                    Year = 2007,
                    Director = "Akiva Schaffer",
                    Rating = "PG-13",
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    CategoryId = 1,
                    Title = "The Avengers",
                    Year = 2012,
                    Director = "Anthony Russo",
                    Rating = "PG-13",
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    CategoryId = 2,
                    Title = "Megamind",
                    Year = 2010,
                    Director = "Tom McGrath",
                    Rating = "PG  ",
                }
                );
        }
    }
}
