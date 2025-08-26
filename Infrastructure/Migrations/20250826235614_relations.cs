using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
