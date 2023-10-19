using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicsProject.Migrations
{
    /// <inheritdoc />
    public partial class Sports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Sport_SportName",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sport",
                table: "Sport");

            migrationBuilder.RenameTable(
                name: "Sport",
                newName: "Sports");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sports",
                table: "Sports",
                column: "SportName");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Sports_SportName",
                table: "Countries",
                column: "SportName",
                principalTable: "Sports",
                principalColumn: "SportName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Sports_SportName",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sports",
                table: "Sports");

            migrationBuilder.RenameTable(
                name: "Sports",
                newName: "Sport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sport",
                table: "Sport",
                column: "SportName");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Sport_SportName",
                table: "Countries",
                column: "SportName",
                principalTable: "Sport",
                principalColumn: "SportName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
