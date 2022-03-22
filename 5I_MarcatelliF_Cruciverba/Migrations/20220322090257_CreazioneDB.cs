using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5I_MarcatelliF_Cruciverba.Migrations
{
    public partial class CreazioneDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cruciverba",
                columns: table => new
                {
                    CruciverbaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Solution = table.Column<string>(type: "TEXT", nullable: true),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruciverba", x => x.CruciverbaId);
                });

            migrationBuilder.CreateTable(
                name: "Suggerimenti",
                columns: table => new
                {
                    SuggerimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: true),
                    isHoriz = table.Column<bool>(type: "INTEGER", nullable: false),
                    CruciverbaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggerimenti", x => x.SuggerimentoId);
                    table.ForeignKey(
                        name: "FK_Suggerimenti_Cruciverba_CruciverbaId",
                        column: x => x.CruciverbaId,
                        principalTable: "Cruciverba",
                        principalColumn: "CruciverbaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suggerimenti_CruciverbaId",
                table: "Suggerimenti",
                column: "CruciverbaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suggerimenti");

            migrationBuilder.DropTable(
                name: "Cruciverba");
        }
    }
}
