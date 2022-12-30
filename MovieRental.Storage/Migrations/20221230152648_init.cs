using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRental.Storage.Migrations
{
    public partial class init : Migration
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
                    Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    FovriteGenreId = table.Column<int>(type: "int", nullable: true),
                    RentedMoviesId = table.Column<int>(type: "int", nullable: false),
                    RoleType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Genres_FovriteGenreId",
                        column: x => x.FovriteGenreId,
                        principalTable: "Genres",
                        principalColumn: "Id");
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
                name: "GenreMovie",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingNumber = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_MovieId",
                        column: x => x.MovieId,
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
                columns: new[] { "Id", "FirstName", "Image_Url", "LastName" },
                values: new object[,]
                {
                    { 1, "Steven", "https://upload.wikimedia.org/wikipedia/commons/6/67/Steven_Spielberg_by_Gage_Skidmore.jpg", "Spielberg" },
                    { 2, "Chris", "https://flxt.tmsimg.com/assets/86548_v9_bb.jpg", "Columbus" },
                    { 3, "Joe", "https://m.media-amazon.com/images/M/MV5BNzcxNDQwNzgxNV5BMl5BanBnXkFtZTYwNTQ1MTA0._V1_.jpg", "Johnston" },
                    { 4, "Andrew", "https://flxt.tmsimg.com/assets/238057_v9_ba.jpg", "Adamson" },
                    { 5, "Wolfgang", "https://images.mubicdn.net/images/cast_member/28582/cache-6755-1656674147/image-w856.jpg?size=800x", "Reitherman" },
                    { 6, "Rob ", "https://flxt.tmsimg.com/assets/161246_v9_bb.jpg", "Minkoff" },
                    { 7, "Roger", "https://flxt.tmsimg.com/assets/161245_v9_ba.jpg", "Allers" },
                    { 8, "Raja", "https://resizing.flixster.com/NF1S1bg13STVPI39JymDzl8it8Q=/218x280/v2/https://flxt.tmsimg.com/assets/78732_v9_bb.jpg", "Gosnell" },
                    { 9, "Peter ", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRQHnA-V4DqU8xDTpwsADvNWat9IbAgrkKifsp-NUyoHSy5AGw6", "Jackson" },
                    { 10, "Peter ", "https://www.etonline.com/sites/default/files/styles/max_1280x720/public/images/2019-01/peter_farrelly_gettyimages-1079456294_1280.jpg?h=c673cd1c&itok=zBxwVhm8", "Farrelly" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Drama" },
                    { 2, "Comedy" },
                    { 3, "Action" },
                    { 4, "Fantasy" },
                    { 5, "Horror" },
                    { 6, "Romance" },
                    { 7, "Western" },
                    { 8, "Thriller" },
                    { 9, "Animation" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Alien in planet earth with a young boy", "https://m.media-amazon.com/images/I/814-9+LgNTL._AC_SY445_.jpg", "E.T", new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "A boy home alone", "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/zYPsleQJo1n1rBPlecJBRb3iwSO.jpg", "Home Alone", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "When two kids find and play a magical board game, they release a man trapped in it for decades.", "https://resizing.flixster.com/ubZExJkNr_7S3Nr1I8-wk8lg4DU=/206x305/v2/https://flxt.tmsimg.com/assets/p15446613_p_v8_ac.jpg", "Jumanji", new DateTime(1995, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Four kids travel through a wardrobe to the land of Narnia and learn of their destiny to free it with the guidance of a mystical lion.", "https://m.media-amazon.com/images/M/MV5BMTc0NTUwMTU5OV5BMl5BanBnXkFtZTcwNjAwNzQzMw@@._V1_.jpg", "Narnian", new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Mowgli is a boy brought up in the jungle by a pack of wolves. When Shere Khan, a tiger, threatens to kill him, a panther and a bear help him escape his clutches.", "https://m.media-amazon.com/images/I/51qv0ish5JL._SY445_.jpg", "Jungle Book", new DateTime(1987, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "As a cub, Simba is forced to leave the Pride Lands after his father Mufasa is murdered by his wicked uncle, Scar. Years later, he returns as a young lion to reclaim his throne.", "https://lumiere-a.akamaihd.net/v1/images/p_thelionking2019_19732_c1561d41.jpeg?region=0%2C0%2C540%2C810", "Lion King", new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Scooby-Doo! Mystery Mayhem is a video game based on the Hanna-Barbera/Warner Bros. cartoon Scooby-Doo. ", "https://upload.wikimedia.org/wikipedia/en/a/ae/Scooby-Doo_poster.jpg", "Scooby Doo", new DateTime(2005, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "https://images.squarespace-cdn.com/content/v1/5935bdc315cf7d45e895fdfe/1557857896793-H0GROSO5OUE9NDE2IZ2I/LOTF---TTT-poster-credit-to-Metropolitan-Festival-Orchestra.jpg?format=1500w", "The Lord of the Rings: The Return of the King", new DateTime(2003, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "A working-class Italian-American bouncer becomes the driver for an African-American classical pianist on a tour of venues through the 1960s American South.", "https://movieposters2.com/images/1614370-b.jpg", "Green Book", new DateTime(2018, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "When aliens misinterpret video feeds of classic arcade games as a declaration of war, they attack the Earth in the form of the video games.", "https://images-na.ssl-images-amazon.com/images/S/pv-target-images/856aa43a655cd0c2b44f0e99bf8daed3b817c72b289ec0557469ca3f420af75a._RI_V_TTW_.png", "Pixels", new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "FovriteGenreId", "LastName", "Password", "RentedMoviesId", "RoleType", "UserName" },
                values: new object[,]
                {
                    { 1, "DinkoTest", null, "Dinko123", "??hO?S3??z|+?n", 0, 1, "Dinko" },
                    { 2, "VanjaTest", null, "Vanja123", "u??ZsE?????D?", 0, 0, "Vanja" },
                    { 3, "CvetanTest", null, "Cvetan123", "????`??E#B????y", 0, 0, "Cvetan" },
                    { 4, "MikiTest", null, "Miki123", "??}5?[??XS{???=", 0, 0, "Miki" }
                });

            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "DirectorsId", "ListMoviesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 10 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 }
                });

            migrationBuilder.InsertData(
                table: "GenreMovie",
                columns: new[] { "GenresId", "MoviesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 1, 9 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 8 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 8 },
                    { 4, 10 },
                    { 9, 5 },
                    { 9, 6 },
                    { 9, 7 }
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
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "RatingNumber" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 2, 1, 10 },
                    { 3, 2, 8 },
                    { 4, 2, 8 },
                    { 5, 3, 10 },
                    { 6, 3, 9 },
                    { 7, 4, 8 },
                    { 8, 5, 8 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "RatingNumber" },
                values: new object[,]
                {
                    { 9, 6, 9 },
                    { 10, 7, 6 },
                    { 11, 7, 9 },
                    { 12, 8, 8 },
                    { 13, 8, 7 },
                    { 14, 8, 5 },
                    { 15, 9, 10 },
                    { 16, 9, 5 },
                    { 17, 10, 8 },
                    { 18, 10, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectorMovie_ListMoviesId",
                table: "DirectorMovie",
                column: "ListMoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UserId",
                table: "MovieUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FovriteGenreId",
                table: "Users",
                column: "FovriteGenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectorMovie");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
