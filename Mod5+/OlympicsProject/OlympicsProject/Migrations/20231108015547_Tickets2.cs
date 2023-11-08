using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicsProject.Migrations
{
    /// <inheritdoc />
    public partial class Tickets2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Description", "PointValue", "SprintNumber", "Status", "TicketName" },
                values: new object[] { 1, "Finish Homework", 1, 1, "Quality Assurance", "Homework" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketID",
                keyValue: 1);
        }
    }
}
