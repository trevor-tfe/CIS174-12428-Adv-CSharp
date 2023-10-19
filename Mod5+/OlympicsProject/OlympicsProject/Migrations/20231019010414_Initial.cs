using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OlympicsProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    SportName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.SportName);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SportName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Sport_SportName",
                        column: x => x.SportName,
                        principalTable: "Sport",
                        principalColumn: "SportName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sport",
                columns: new[] { "SportName", "Category", "Type" },
                values: new object[,]
                {
                    { "Archery", "Paralympics", "Indoor" },
                    { "Bobsleigh", "Winter Olympics", "Outdoor" },
                    { "Breakdancing", "Youth Olympic Games", "Indoor" },
                    { "Canoe Sprint", "Paralympics", "Outdoor" },
                    { "Curling", "Winter Olympics", "Indoor" },
                    { "Diving", "Summer Olympics", "Indoor" },
                    { "Road Cycling", "Summer Olympics", "Outdoor" },
                    { "Skateboarding", "Youth Olympic Games", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Flag", "Name", "SportName" },
                values: new object[,]
                {
                    { 1, "Images/canada.jpg", "Canada", "Curling" },
                    { 2, "Images/sweden.jpg", "Sweden", "Curling" },
                    { 3, "Images/great_britain.jpg", "Great Britain", "Curling" },
                    { 4, "Images/jamaica.jpg", "Jamaica", "Bobsleigh" },
                    { 5, "Images/italy.jpg", "Italy", "Bobsleigh" },
                    { 6, "Images/japan.jpg", "Japan", "Bobsleigh" },
                    { 7, "Images/germany.jpg", "Germany", "Diving" },
                    { 8, "Images/china.jpg", "China", "Diving" },
                    { 9, "Images/mexico.jpg", "Mexico", "Diving" },
                    { 10, "Images/brazil.jpg", "Brazil", "Road Cycling" },
                    { 11, "Images/netherlands.jpg", "Netherlands", "Road Cycling" },
                    { 12, "Images/united_states.jpg", "USA", "Road Cycling" },
                    { 13, "Images/thailand.jpg", "Thailand", "Archery" },
                    { 14, "Images/uruguay.jpg", "Uruguay", "Archery" },
                    { 15, "Images/ukraine.jpg", "Ukraine", "Archery" },
                    { 16, "Images/austria.jpg", "Austria", "Canoe Sprint" },
                    { 17, "Images/pakistan.jpg", "Pakistan", "Canoe Sprint" },
                    { 18, "Images/zimbabwe.jpg", "Zimbabwe", "Canoe Sprint" },
                    { 19, "Images/france.jpg", "France", "Breakdancing" },
                    { 20, "Images/cyprus.jpg", "Cyprus", "Breakdancing" },
                    { 21, "Images/russia.jpg", "Russia", "Breakdancing" },
                    { 22, "Images/finland.jpg", "Finland", "Skateboarding" },
                    { 23, "Images/slovakia.jpg", "Slovakia", "Skateboarding" },
                    { 24, "Images/portugal.jpg", "Portugal", "Skateboarding" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportName",
                table: "Countries",
                column: "SportName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Sport");
        }
    }
}
