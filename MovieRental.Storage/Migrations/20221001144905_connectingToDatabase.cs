using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRental.Storage.Migrations
{
    public partial class ConnectingToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListMoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DirecorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FovriteGenre = table.Column<int>(type: "int", nullable: true),
                    RentedMoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectorMovie",
                columns: table => new
                {
                    DirectorsId = table.Column<int>(type: "int", nullable: false),
                    ListMoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorMovie", x => new { x.DirectorsId, x.ListMoviesId });
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Directors_DirectorsId",
                        column: x => x.DirectorsId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorMovie_Movies_ListMoviesId",
                        column: x => x.ListMoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    RentedMoviesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.RentedMoviesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MovieUser_Movies_RentedMoviesId",
                        column: x => x.RentedMoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "LastName", "ListMoviesId" },
                values: new object[,]
                {
                    { 1, "Steven", "Spielberg", 0 },
                    { 2, "Chris", "Columbus", 0 },
                    { 3, "Joe", "Johnston", 0 },
                    { 4, "Andrew", "Adamson", 0 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirecorId", "Genre", "ImageUrl", "Title", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Alien in planet earth with a young boy", 0, 3, "https://m.media-amazon.com/images/I/814-9+LgNTL._AC_SY445_.jpg", "E.T", 0, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "A boy home alone", 0, 1, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/zYPsleQJo1n1rBPlecJBRb3iwSO.jpg", "Home Alone", 0, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "When two kids find and play a magical board game, they release a man trapped in it for decades.", 0, 3, "https://resizing.flixster.com/ubZExJkNr_7S3Nr1I8-wk8lg4DU=/206x305/v2/https://flxt.tmsimg.com/assets/p15446613_p_v8_ac.jpg", "Jumanji", 0, new DateTime(1995, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Four kids travel through a wardrobe to the land of Narnia and learn of their destiny to free it with the guidance of a mystical lion.", 0, 2, "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_.jpg", "Narnian", 0, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "FovriteGenre", "LastName", "Password", "RentedMoviesId", "UserName" },
                values: new object[,]
                {
                    { 1, "DinkoTest", null, "Dinko123", "Lord", 0, "Dinko" },
                    { 2, "VanjaTest", null, "Vanja123", "Vanja1", 0, "Vanja" },
                    { 3, "CvetanTest", null, "Cvetan123", "Cvetan", 0, "Cvetan" },
                    { 4, "MikiTest", null, "Miki123", "Miki", 0, "Miki" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovie_ListMoviesId",
                table: "DirectorMovie",
                column: "ListMoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UserId",
                table: "MovieUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectorMovie");

            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
