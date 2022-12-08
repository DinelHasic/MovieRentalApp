﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRental.Storage.Database;

#nullable disable

namespace MovieRental.Storage.Migrations
{
    [DbContext(typeof(MovieRentalDbContext))]
    [Migration("20221001145722_addRelation")]
    partial class AddRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.Property<int>("DirectorsId")
                        .HasColumnType("int");

                    b.Property<int>("ListMoviesId")
                        .HasColumnType("int");

                    b.HasKey("DirectorsId", "ListMoviesId");

                    b.HasIndex("ListMoviesId");

                    b.ToTable("DirectorMovie");

                    b.HasData(
                        new
                        {
                            DirectorsId = 1,
                            ListMoviesId = 1
                        },
                        new
                        {
                            DirectorsId = 2,
                            ListMoviesId = 2
                        },
                        new
                        {
                            DirectorsId = 3,
                            ListMoviesId = 3
                        },
                        new
                        {
                            DirectorsId = 4,
                            ListMoviesId = 4
                        });
                });

            modelBuilder.Entity("MovieRental.Domain.Enteties.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ListMoviesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Steven",
                            LastName = "Spielberg",
                            ListMoviesId = 0
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Chris",
                            LastName = "Columbus",
                            ListMoviesId = 0
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Joe",
                            LastName = "Johnston",
                            ListMoviesId = 0
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Andrew",
                            LastName = "Adamson",
                            ListMoviesId = 0
                        });
                });

            modelBuilder.Entity("MovieRental.Domain.Enteties.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirecorId")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Alien in planet earth with a young boy",
                            DirecorId = 0,
                            Genre = 3,
                            ImageUrl = "https://m.media-amazon.com/images/I/814-9+LgNTL._AC_SY445_.jpg",
                            Title = "E.T",
                            UserId = 0,
                            Year = new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "A boy home alone",
                            DirecorId = 0,
                            Genre = 1,
                            ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/zYPsleQJo1n1rBPlecJBRb3iwSO.jpg",
                            Title = "Home Alone",
                            UserId = 0,
                            Year = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Description = "When two kids find and play a magical board game, they release a man trapped in it for decades.",
                            DirecorId = 0,
                            Genre = 3,
                            ImageUrl = "https://resizing.flixster.com/ubZExJkNr_7S3Nr1I8-wk8lg4DU=/206x305/v2/https://flxt.tmsimg.com/assets/p15446613_p_v8_ac.jpg",
                            Title = "Jumanji",
                            UserId = 0,
                            Year = new DateTime(1995, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Description = "Four kids travel through a wardrobe to the land of Narnia and learn of their destiny to free it with the guidance of a mystical lion.",
                            DirecorId = 0,
                            Genre = 2,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_.jpg",
                            Title = "Narnian",
                            UserId = 0,
                            Year = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Description = "Mowgli is a boy brought up in the jungle by a pack of wolves. When Shere Khan, a tiger, threatens to kill him, a panther and a bear help him escape his clutches.",
                            DirecorId = 0,
                            Genre = 8,
                            ImageUrl = "https://m.media-amazon.com/images/I/51qv0ish5JL._SY445_.jpg",
                            Title = "Jungle Book",
                            UserId = 0,
                            Year = new DateTime(1987, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Description = "As a cub, Simba is forced to leave the Pride Lands after his father Mufasa is murdered by his wicked uncle, Scar. Years later, he returns as a young lion to reclaim his throne.",
                            DirecorId = 0,
                            Genre = 8,
                            ImageUrl = "https://play-lh.googleusercontent.com/sxMhq5US2nRdYrfER_Z_K5RChyifJmKrWIK650KeJW7eqggKkGSNjGHnIsyrIOg-YDfYXg=w240-h480-rw",
                            Title = "Lion King",
                            UserId = 0,
                            Year = new DateTime(1994, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Description = "Scooby-Doo! Mystery Mayhem is a video game based on the Hanna-Barbera/Warner Bros. cartoon Scooby-Doo. ",
                            DirecorId = 0,
                            Genre = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ae/Scooby-Doo_poster.jpg",
                            Title = "Scooby Doo",
                            UserId = 0,
                            Year = new DateTime(2005, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieRental.Domain.Enteties.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FovriteGenre")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RentedMoviesId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "DinkoTest",
                            LastName = "Dinko123",
                            Password = "Lord",
                            RentedMoviesId = 0,
                            UserName = "Dinko"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "VanjaTest",
                            LastName = "Vanja123",
                            Password = "Vanja1",
                            RentedMoviesId = 0,
                            UserName = "Vanja"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "CvetanTest",
                            LastName = "Cvetan123",
                            Password = "Cvetan",
                            RentedMoviesId = 0,
                            UserName = "Cvetan"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "MikiTest",
                            LastName = "Miki123",
                            Password = "Miki",
                            RentedMoviesId = 0,
                            UserName = "Miki"
                        });
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.Property<int>("RentedMoviesId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RentedMoviesId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MovieUser");

                    b.HasData(
                        new
                        {
                            RentedMoviesId = 1,
                            UserId = 1
                        },
                        new
                        {
                            RentedMoviesId = 2,
                            UserId = 1
                        },
                        new
                        {
                            RentedMoviesId = 3,
                            UserId = 2
                        },
                        new
                        {
                            RentedMoviesId = 2,
                            UserId = 2
                        },
                        new
                        {
                            RentedMoviesId = 4,
                            UserId = 3
                        },
                        new
                        {
                            RentedMoviesId = 1,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("DirectorMovie", b =>
                {
                    b.HasOne("MovieRental.Domain.Enteties.Director", null)
                        .WithMany()
                        .HasForeignKey("DirectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRental.Domain.Enteties.Movie", null)
                        .WithMany()
                        .HasForeignKey("ListMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieUser", b =>
                {
                    b.HasOne("MovieRental.Domain.Enteties.Movie", null)
                        .WithMany()
                        .HasForeignKey("RentedMoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieRental.Domain.Enteties.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
