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
                    FirstName = "Michael",
                    LastName = "Scott",
                    Age = 43,
                    Phone = "8018018018",
                    Major = "Paper Stuff",
                    CreeperStalker = false
                },
                new ApplicationResponse
                {
                    ApplicationID = 2,
                    FirstName = "Creed",
                    LastName = "Bratton",
                    Age = 90,
                    Phone = "803iu2ho2",
                    Major = "Undeclared",
                    CreeperStalker = true
                }
                );
        }
    }
}
