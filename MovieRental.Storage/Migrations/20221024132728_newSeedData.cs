using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRental.Storage.Migrations
{
    public partial class NewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirecorId", "Genre", "ImageUrl", "Title", "UserId", "Year" },
                values: new object[] { 8, "The Lord of the Rings: The Return of the King", 0, 2, "https://images.squarespace-cdn.com/content/v1/5935bdc315cf7d45e895fdfe/1557857896793-H0GROSO5OUE9NDE2IZ2I/LOTF---TTT-poster-credit-to-Metropolitan-Festival-Orchestra.jpg?format=1500w", "Scooby Doo", 0, new DateTime(2003, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirecorId", "Genre", "ImageUrl", "Title", "UserId", "Year" },
                values: new object[] { 9, "A working-class Italian-American bouncer becomes the driver for an African-American classical pianist on a tour of venues through the 1960s American South.", 0, 0, "https://movieposters2.com/images/1614370-b.jpg", "Green Book", 0, new DateTime(2018, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirecorId", "Genre", "ImageUrl", "Title", "UserId", "Year" },
                values: new object[] { 10, "When aliens misinterpret video feeds of classic arcade games as a declaration of war, they attack the Earth in the form of the video games.", 0, 1, "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/856aa43a655cd0c2b44f0e99bf8daed3b817c72b289ec0557469ca3f420af75a._RI_V_TTW_.png", "Pixels", 0, new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
