using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace module_4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtistSongs",
                columns: table => new
                {
                    ArtistSongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSongs", x => x.ArtistSongId);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistSongId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                    table.ForeignKey(
                        name: "FK_Artists_ArtistSongs_ArtistSongId",
                        column: x => x.ArtistSongId,
                        principalTable: "ArtistSongs",
                        principalColumn: "ArtistSongId");
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ArtistSongId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_ArtistSongs_ArtistSongId",
                        column: x => x.ArtistSongId,
                        principalTable: "ArtistSongs",
                        principalColumn: "ArtistSongId");
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                    table.ForeignKey(
                        name: "FK_Genres_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ArtistSongs",
                columns: new[] { "ArtistSongId", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "ArtistSongId", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1979, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelis@email", "@Kelis", "Kelis", 5553535 },
                    { 2, null, new DateTime(2003, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "TRJA@email", "@TRJA", "The Red Jumpsuit Apparatus", 5553535 },
                    { 3, null, new DateTime(1989, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kizaru@email", "@Kizaru", "Kizaru", 5553535 }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "ArtistSongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, null, "3:26", 1, new DateTime(2003, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trick Me" },
                    { 2, null, "3:12", 1, new DateTime(2006, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Face Down" },
                    { 3, null, "2:15", 2, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Money long" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ArtistSongId",
                table: "Artists",
                column: "ArtistSongId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_SongId",
                table: "Genres",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ArtistSongId",
                table: "Songs",
                column: "ArtistSongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "ArtistSongs");
        }
    }
}
