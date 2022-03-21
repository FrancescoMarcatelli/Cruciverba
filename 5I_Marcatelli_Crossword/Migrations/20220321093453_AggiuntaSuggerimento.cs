using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5I_Marcatelli_Crossword.Migrations
{
    public partial class AggiuntaSuggerimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuggerimentoId",
                table: "Cruciverba",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suggerimenti",
                columns: table => new
                {
                    SuggerimentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: true),
                    isHoriz = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggerimenti", x => x.SuggerimentoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cruciverba_SuggerimentoId",
                table: "Cruciverba",
                column: "SuggerimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cruciverba_Suggerimenti_SuggerimentoId",
                table: "Cruciverba",
                column: "SuggerimentoId",
                principalTable: "Suggerimenti",
                principalColumn: "SuggerimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cruciverba_Suggerimenti_SuggerimentoId",
                table: "Cruciverba");

            migrationBuilder.DropTable(
                name: "Suggerimenti");

            migrationBuilder.DropIndex(
                name: "IX_Cruciverba_SuggerimentoId",
                table: "Cruciverba");

            migrationBuilder.DropColumn(
                name: "SuggerimentoId",
                table: "Cruciverba");
        }
    }
}
