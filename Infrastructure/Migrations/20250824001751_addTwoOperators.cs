using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTwoOperators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Operators",
                columns: new[] { "DNI", "Deleted", "Email", "LastName", "NLegajo", "Name", "Password", "Phone", "Position" },
                values: new object[,]
                {
                    { 43567210, 0, "lucas@example.com", "Fernandez", 459851, "Lucas", "abc12345", "3416549871", 2 },
                    { 46502865, 0, "micaela@example.com", "Ortigoza", 459850, "Micaela", "123abc", "3416897542", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Operators",
                keyColumn: "DNI",
                keyValue: 43567210);

            migrationBuilder.DeleteData(
                table: "Operators",
                keyColumn: "DNI",
                keyValue: 46502865);
        }
    }
}
