using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IncidenceData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Incidences",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Incidences",
                columns: new[] { "Id", "Date", "Deleted", "Department", "Description", "IncidenceType", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 9, 16, 30, 40, 887, DateTimeKind.Utc).AddTicks(885), 0, 4, "Luz rota en Av. Pellegrini 2000", 1, 0 },
                    { 2, new DateTime(2025, 9, 7, 16, 30, 40, 887, DateTimeKind.Utc).AddTicks(887), 0, 1, "Bache en San Martín y Rioja", 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Incidences");
        }
    }
}
