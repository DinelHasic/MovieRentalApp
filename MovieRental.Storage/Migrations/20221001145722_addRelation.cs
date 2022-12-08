using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRental.Storage.Migrations
{
    public partial class AddRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "DirectorsId", "ListMoviesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "MovieUser",
                columns: new[] { "RentedMoviesId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirecorId", "Genre", "ImageUrl", "Title", "UserId", "Year" },
                values: new object[,]
                {
                    { 5, "Mowgli is a boy brought up in the jungle by a pack of wolves. When Shere Khan, a tiger, threatens to kill him, a panther and a bear help him escape his clutches.", 0, 8, "https://m.media-amazon.com/images/I/51qv0ish5JL._SY445_.jpg", "Jungle Book", 0, new DateTime(1987, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "As a cub, Simba is forced to leave the Pride Lands after his father Mufasa is murdered by his wicked uncle, Scar. Years later, he returns as a young lion to reclaim his throne.", 0, 8, "https://play-lh.googleusercontent.com/sxMhq5US2nRdYrfER_Z_K5RChyifJmKrWIK650KeJW7eqggKkGSNjGHnIsyrIOg-YDfYXg=w240-h480-rw", "Lion King", 0, new DateTime(1994, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Scooby-Doo! Mystery Mayhem is a video game based on the Hanna-Barbera/Warner Bros. cartoon Scooby-Doo. ", 0, 1, "https://upload.wikimedia.org/wikipedia/en/a/ae/Scooby-Doo_poster.jpg", "Scooby Doo", 0, new DateTime(2005, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "MovieUser",
                keyColumns: new[] { "RentedMoviesId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MovieUser",
                keyColumns: new[] { "RentedMoviesId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "MovieUser",
                keyColumns: new[] { "RentedMoviesId", "UserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MovieUser",
                keyColumns: new[] { "RentedMoviesId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieUser",
                keyColumns: new[] { "RentedMoviesId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MovieUser",
                keyColumns: new[] { "RentedMoviesId", "UserId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
