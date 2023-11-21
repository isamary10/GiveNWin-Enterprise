using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    /// <inheritdoc />
    public partial class Relacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoadorId",
                table: "TB_GIVEWIN_DOACAO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReceptorId",
                table: "TB_GIVEWIN_DOACAO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DoacaoTipoDoacoes",
                columns: table => new
                {
                    DoacaoId = table.Column<int>(type: "int", nullable: false),
                    TipoDoacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoacaoTipoDoacoes", x => new { x.DoacaoId, x.TipoDoacaoId });
                    table.ForeignKey(
                        name: "FK_DoacaoTipoDoacoes_TB_GIVEWIN_DOACAO_DoacaoId",
                        column: x => x.DoacaoId,
                        principalTable: "TB_GIVEWIN_DOACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoacaoTipoDoacoes_TB_GIVEWIN_TIPO_DOACAO_TipoDoacaoId",
                        column: x => x.TipoDoacaoId,
                        principalTable: "TB_GIVEWIN_TIPO_DOACAO",
                        principalColumn: "TipoDoacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_GIVEWIN_DOACAO_DoadorId",
                table: "TB_GIVEWIN_DOACAO",
                column: "DoadorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_GIVEWIN_DOACAO_ReceptorId",
                table: "TB_GIVEWIN_DOACAO",
                column: "ReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoacaoTipoDoacoes_TipoDoacaoId",
                table: "DoacaoTipoDoacoes",
                column: "TipoDoacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GIVEWIN_DOACAO_TB_GIVEWIN_DOADOR_DoadorId",
                table: "TB_GIVEWIN_DOACAO",
                column: "DoadorId",
                principalTable: "TB_GIVEWIN_DOADOR",
                principalColumn: "DoadorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GIVEWIN_DOACAO_TB_GIVEWIN_RECEPTOR_ReceptorId",
                table: "TB_GIVEWIN_DOACAO",
                column: "ReceptorId",
                principalTable: "TB_GIVEWIN_RECEPTOR",
                principalColumn: "ReceptorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_GIVEWIN_DOACAO_TB_GIVEWIN_DOADOR_DoadorId",
                table: "TB_GIVEWIN_DOACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_GIVEWIN_DOACAO_TB_GIVEWIN_RECEPTOR_ReceptorId",
                table: "TB_GIVEWIN_DOACAO");

            migrationBuilder.DropTable(
                name: "DoacaoTipoDoacoes");

            migrationBuilder.DropIndex(
                name: "IX_TB_GIVEWIN_DOACAO_DoadorId",
                table: "TB_GIVEWIN_DOACAO");

            migrationBuilder.DropIndex(
                name: "IX_TB_GIVEWIN_DOACAO_ReceptorId",
                table: "TB_GIVEWIN_DOACAO");

            migrationBuilder.DropColumn(
                name: "DoadorId",
                table: "TB_GIVEWIN_DOACAO");

            migrationBuilder.DropColumn(
                name: "ReceptorId",
                table: "TB_GIVEWIN_DOACAO");
        }
    }
}
