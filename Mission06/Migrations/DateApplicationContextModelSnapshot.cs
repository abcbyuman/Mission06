﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06.Models;

namespace Mission06.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    partial class DateApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission06.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            Category = "Comedy",
                            Director = "Akiva Schaffer",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Hot Rod",
                            Year = 2007
                        },
                        new
                        {
                            ApplicationID = 2,
                            Category = "Action",
                            Director = "Anthony Russo",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Avengers",
                            Year = 2012
                        },
                        new
                        {
                            ApplicationID = 3,
                            Category = "Comedy",
                            Director = "Tom McGrath",
                            Edited = false,
                            Rating = "PG",
                            Title = "Megamind",
                            Year = 2010
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
