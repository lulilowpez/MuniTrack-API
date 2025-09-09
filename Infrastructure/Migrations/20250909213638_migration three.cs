using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migrationthree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Citizens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "DNI",
                keyValue: 43567210,
                column: "Deleted",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "DNI",
                keyValue: 46502865,
                column: "Deleted",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 9, 21, 36, 37, 973, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 9, 7, 21, 36, 37, 973, DateTimeKind.Utc).AddTicks(5026));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Citizens");

            migrationBuilder.UpdateData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 9, 18, 54, 58, 773, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 9, 7, 18, 54, 58, 773, DateTimeKind.Utc).AddTicks(2411));
        }
    }
}
