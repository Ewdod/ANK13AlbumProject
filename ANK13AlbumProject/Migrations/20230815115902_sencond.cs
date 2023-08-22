using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK13AlbumProject.Migrations
{
    /// <inheritdoc />
    public partial class sencond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sanatci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SatisDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");
        }
    }
}
