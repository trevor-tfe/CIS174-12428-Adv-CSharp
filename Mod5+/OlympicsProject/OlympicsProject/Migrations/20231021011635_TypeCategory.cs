using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OlympicsProject.Migrations
{
    /// <inheritdoc />
    public partial class TypeCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Sports");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Sports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Sports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Winter Olympics" },
                    { 2, "Summer Olympics" },
                    { 3, "Paralympics" },
                    { 4, "Youth Olympic Games" }
                });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Archery",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Bobsleigh",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Breakdancing",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Canoe Sprint",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Curling",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Diving",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Road Cycling",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Skateboarding",
                columns: new[] { "CategoryId", "TypeId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "Indoor" },
                    { 2, "Outdoor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sports_CategoryId",
                table: "Sports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sports_TypeId",
                table: "Sports",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sports_Categories_CategoryId",
                table: "Sports",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sports_Types_TypeId",
                table: "Sports",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sports_Categories_CategoryId",
                table: "Sports");

            migrationBuilder.DropForeignKey(
                name: "FK_Sports_Types_TypeId",
                table: "Sports");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Sports_CategoryId",
                table: "Sports");

            migrationBuilder.DropIndex(
                name: "IX_Sports_TypeId",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Sports");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Sports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Sports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Archery",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Paralympics", "Indoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Bobsleigh",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Winter Olympics", "Outdoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Breakdancing",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Youth Olympic Games", "Indoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Canoe Sprint",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Paralympics", "Outdoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Curling",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Winter Olympics", "Indoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Diving",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Summer Olympics", "Indoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Road Cycling",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Summer Olympics", "Outdoor" });

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportName",
                keyValue: "Skateboarding",
                columns: new[] { "Category", "Type" },
                values: new object[] { "Youth Olympic Games", "Outdoor" });
        }
    }
}
