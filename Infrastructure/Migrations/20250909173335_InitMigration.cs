using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Deleted = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    DNI = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.DNI);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    NLegajo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DNI = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    Deleted = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.NLegajo);
                });

            migrationBuilder.CreateTable(
                name: "Incidences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IncidenceType = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<int>(type: "INTEGER", nullable: false),
                    AreaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Deleted = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidences_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitizenOperator",
                columns: table => new
                {
                    CitizensDNI = table.Column<int>(type: "INTEGER", nullable: false),
                    OperatorNLegajo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenOperator", x => new { x.CitizensDNI, x.OperatorNLegajo });
                    table.ForeignKey(
                        name: "FK_CitizenOperator_Citizens_CitizensDNI",
                        column: x => x.CitizensDNI,
                        principalTable: "Citizens",
                        principalColumn: "DNI",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitizenOperator_Operators_OperatorNLegajo",
                        column: x => x.OperatorNLegajo,
                        principalTable: "Operators",
                        principalColumn: "NLegajo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitizenIncidence",
                columns: table => new
                {
                    CitizenDNI = table.Column<int>(type: "INTEGER", nullable: false),
                    IncidencesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenIncidence", x => new { x.CitizenDNI, x.IncidencesId });
                    table.ForeignKey(
                        name: "FK_CitizenIncidence_Citizens_CitizenDNI",
                        column: x => x.CitizenDNI,
                        principalTable: "Citizens",
                        principalColumn: "DNI",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitizenIncidence_Incidences_IncidencesId",
                        column: x => x.IncidencesId,
                        principalTable: "Incidences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncidenceOperator",
                columns: table => new
                {
                    IncidencesId = table.Column<int>(type: "INTEGER", nullable: false),
                    OperatorNLegajo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidenceOperator", x => new { x.IncidencesId, x.OperatorNLegajo });
                    table.ForeignKey(
                        name: "FK_IncidenceOperator_Incidences_IncidencesId",
                        column: x => x.IncidencesId,
                        principalTable: "Incidences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IncidenceOperator_Operators_OperatorNLegajo",
                        column: x => x.OperatorNLegajo,
                        principalTable: "Operators",
                        principalColumn: "NLegajo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "Id", "Deleted", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Atiende trámites generales", "Oficina Martin Fierro" },
                    { 2, 0, "Atiende temas de género", "Oficina Gender" }
                });

            migrationBuilder.InsertData(
                table: "Operators",
                columns: new[] { "NLegajo", "DNI", "Deleted", "Email", "LastName", "Name", "Password", "Phone", "Position" },
                values: new object[,]
                {
                    { 459850, 46502865, 0, "micaela@example.com", "Ortigoza", "Micaela", "123abc", "3416897542", 3 },
                    { 459851, 43567210, 0, "lucas@example.com", "Fernandez", "Lucas", "abc12345", "3416549871", 2 }
                });

            migrationBuilder.InsertData(
                table: "Incidences",
                columns: new[] { "Id", "AreaId", "Date", "Deleted", "Description", "IncidenceType", "State" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 9, 17, 33, 35, 287, DateTimeKind.Utc).AddTicks(9418), 0, "Luz rota en Av. Pellegrini 2000", 1, 0 },
                    { 2, 2, new DateTime(2025, 9, 7, 17, 33, 35, 287, DateTimeKind.Utc).AddTicks(9420), 0, "Bache en San Martín y Rioja", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitizenIncidence_IncidencesId",
                table: "CitizenIncidence",
                column: "IncidencesId");

            migrationBuilder.CreateIndex(
                name: "IX_CitizenOperator_OperatorNLegajo",
                table: "CitizenOperator",
                column: "OperatorNLegajo");

            migrationBuilder.CreateIndex(
                name: "IX_IncidenceOperator_OperatorNLegajo",
                table: "IncidenceOperator",
                column: "OperatorNLegajo");

            migrationBuilder.CreateIndex(
                name: "IX_Incidences_AreaId",
                table: "Incidences",
                column: "AreaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitizenIncidence");

            migrationBuilder.DropTable(
                name: "CitizenOperator");

            migrationBuilder.DropTable(
                name: "IncidenceOperator");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "Incidences");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Area");
        }
    }
}
