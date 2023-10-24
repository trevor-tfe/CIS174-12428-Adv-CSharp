using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicsProject.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "Flag",
                value: "canada.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "Flag",
                value: "sweden.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                column: "Flag",
                value: "great_britain.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                column: "Flag",
                value: "jamaica.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "Flag",
                value: "italy.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "Flag",
                value: "japan.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7,
                column: "Flag",
                value: "germany.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                column: "Flag",
                value: "china.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9,
                column: "Flag",
                value: "mexico.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10,
                column: "Flag",
                value: "brazil.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11,
                column: "Flag",
                value: "netherlands.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12,
                column: "Flag",
                value: "united_states.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13,
                column: "Flag",
                value: "thailand.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14,
                column: "Flag",
                value: "uruguay.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15,
                column: "Flag",
                value: "ukraine.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16,
                column: "Flag",
                value: "austria.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17,
                column: "Flag",
                value: "pakistan.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18,
                column: "Flag",
                value: "zimbabwe.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19,
                column: "Flag",
                value: "france.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20,
                column: "Flag",
                value: "cyprus.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "Flag",
                value: "russia.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22,
                column: "Flag",
                value: "finland.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23,
                column: "Flag",
                value: "slovakia.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24,
                column: "Flag",
                value: "portugal.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "Flag",
                value: "Images/canada.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "Flag",
                value: "Images/sweden.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                column: "Flag",
                value: "Images/great_britain.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                column: "Flag",
                value: "Images/jamaica.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "Flag",
                value: "Images/italy.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "Flag",
                value: "Images/japan.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7,
                column: "Flag",
                value: "Images/germany.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                column: "Flag",
                value: "Images/china.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9,
                column: "Flag",
                value: "Images/mexico.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10,
                column: "Flag",
                value: "Images/brazil.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11,
                column: "Flag",
                value: "Images/netherlands.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12,
                column: "Flag",
                value: "Images/united_states.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13,
                column: "Flag",
                value: "Images/thailand.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14,
                column: "Flag",
                value: "Images/uruguay.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15,
                column: "Flag",
                value: "Images/ukraine.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16,
                column: "Flag",
                value: "Images/austria.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17,
                column: "Flag",
                value: "Images/pakistan.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18,
                column: "Flag",
                value: "Images/zimbabwe.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19,
                column: "Flag",
                value: "Images/france.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20,
                column: "Flag",
                value: "Images/cyprus.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21,
                column: "Flag",
                value: "Images/russia.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22,
                column: "Flag",
                value: "Images/finland.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23,
                column: "Flag",
                value: "Images/slovakia.jpg");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24,
                column: "Flag",
                value: "Images/portugal.jpg");
        }
    }
}
