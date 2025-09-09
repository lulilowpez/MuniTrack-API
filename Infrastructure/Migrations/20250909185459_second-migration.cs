using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidences_Area_AreaId",
                table: "Incidences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Area",
                table: "Area");

            migrationBuilder.RenameTable(
                name: "Area",
                newName: "Areas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Areas",
                table: "Areas",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "DNI", "Adress", "Email", "LastName", "Name", "Phone" },
                values: new object[,]
                {
                    { 43567210, "Av. San Martín 456", "lucas@example.com", "Fernandez", "Lucas", "3416549871" },
                    { 46502865, "Calle Falsa 123", "micaela@example.com", "Ortigoza", "Micaela", "3416897542" }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Incidences_Areas_AreaId",
                table: "Incidences",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidences_Areas_AreaId",
                table: "Incidences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Areas",
                table: "Areas");

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "DNI",
                keyValue: 43567210);

            migrationBuilder.DeleteData(
                table: "Citizens",
                keyColumn: "DNI",
                keyValue: 46502865);

            migrationBuilder.RenameTable(
                name: "Areas",
                newName: "Area");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Area",
                table: "Area",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 9, 9, 17, 33, 35, 287, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Incidences",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 9, 7, 17, 33, 35, 287, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.AddForeignKey(
                name: "FK_Incidences_Area_AreaId",
                table: "Incidences",
                column: "AreaId",
                principalTable: "Area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
