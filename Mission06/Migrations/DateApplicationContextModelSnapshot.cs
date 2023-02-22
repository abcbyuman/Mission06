﻿// <auto-generated />
using System;
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

                    b.Property<int>("CatId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryCatId")
                        .HasColumnType("INTEGER");

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

                    b.HasIndex("CategoryCatId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationID = 1,
                            CatId = 2,
                            Director = "Akiva Schaffer",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Hot Rod",
                            Year = 2007
                        },
                        new
                        {
                            ApplicationID = 2,
                            CatId = 1,
                            Director = "Anthony Russo",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Avengers",
                            Year = 2012
                        },
                        new
                        {
                            ApplicationID = 3,
                            CatId = 2,
                            Director = "Tom McGrath",
                            Edited = false,
                            Rating = "PG  ",
                            Title = "Megamind",
                            Year = 2010
                        });
                });

            modelBuilder.Entity("Mission06.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CatName")
                        .HasColumnType("TEXT");

                    b.HasKey("CatId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            CatName = "Action"
                        },
                        new
                        {
                            CatId = 2,
                            CatName = "Comedy"
                        },
                        new
                        {
                            CatId = 3,
                            CatName = "Mystery"
                        },
                        new
                        {
                            CatId = 4,
                            CatName = "Horror"
                        },
                        new
                        {
                            CatId = 5,
                            CatName = "N/A"
                        });
                });

            modelBuilder.Entity("Mission06.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission06.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryCatId");
                });
#pragma warning restore 612, 618
        }
    }
}
