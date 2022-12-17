using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRental.Storage.Migrations
{
    public partial class DirectorMovieData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "DirectorsId", "ListMoviesId" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image_Url",
                value: "https://m.media-amazon.com/images/M/MV5BNzcxNDQwNzgxNV5BMl5BanBnXkFtZTYwNTQ1MTA0._V1_.jpg");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image_Url",
                value: "https://flxt.tmsimg.com/assets/238057_v9_ba.jpg");

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "Image_Url", "LastName" },
                values: new object[,]
                {
                    { 5, "Wolfgang", "https://images.mubicdn.net/images/cast_member/28582/cache-6755-1656674147/image-w856.jpg?size=800x", "Reitherman" },
                    { 6, "Rob ", "https://flxt.tmsimg.com/assets/161246_v9_bb.jpg", "Minkoff" },
                    { 7, "Roger", "https://flxt.tmsimg.com/assets/161245_v9_ba.jpg", "Allers" },
                    { 8, "Raja", "https://resizing.flixster.com/NF1S1bg13STVPI39JymDzl8it8Q=/218x280/v2/https://flxt.tmsimg.com/assets/78732_v9_bb.jpg", "Gosnell" },
                    { 9, "Peter ", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRQHnA-V4DqU8xDTpwsADvNWat9IbAgrkKifsp-NUyoHSy5AGw6", "Jackson" },
                    { 10, "Peter ", "https://www.etonline.com/sites/default/files/styles/max_1280x720/public/images/2019-01/peter_farrelly_gettyimages-1079456294_1280.jpg?h=c673cd1c&itok=zBxwVhm8", "Farrelly" }
                });

            migrationBuilder.InsertData(
                table: "DirectorMovie",
                columns: new[] { "DirectorsId", "ListMoviesId" },
                values: new object[,]
                {
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "DirectorMovie",
                keyColumns: new[] { "DirectorsId", "ListMoviesId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image_Url",
                value: "https://static.wikia.nocookie.net/starwars/images/b/b2/JoeJohnston.jpg/revision/latest?cb=20140513071825");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image_Url",
                value: "https://static.wikia.nocookie.net/disney/images/2/2d/Andrew_Adamsom.jpeg/revision/latest?cb=20200703130829");
        }
    }
}
