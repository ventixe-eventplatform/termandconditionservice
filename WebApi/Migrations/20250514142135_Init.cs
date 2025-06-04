using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermId);
                });

            migrationBuilder.CreateTable(
                name: "TermDetails",
                columns: table => new
                {
                    TermDetailId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TermId = table.Column<string>(type: "nvarchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermDetails", x => x.TermDetailId);
                    table.ForeignKey(
                        name: "FK_TermDetails_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "TermId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TermDetails_TermId",
                table: "TermDetails",
                column: "TermId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TermDetails");

            migrationBuilder.DropTable(
                name: "Terms");
        }
    }
}
