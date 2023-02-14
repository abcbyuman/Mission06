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

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            _ = mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationID = 1,
                    Category = "Comedy",
                    Title = "Hot Rod",
                    Year = 2007,
                    Director = "Akiva Schaffer",
                    Rating = "PG-13",
                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    Category = "Action",
                    Title = "The Avengers",
                    Year = 2012,
                    Director = "Anthony Russo",
                    Rating = "PG-13",
                },
                new ApplicationResponse
                {
                    ApplicationID = 3,
                    Category = "Comedy",
                    Title = "Megamind",
                    Year = 2010,
                    Director = "Tom McGrath",
                    Rating = "PG",
                }
                );
        }
    }
}
