using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    /// <inheritdoc />
    public partial class updateDoacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoacaoTipoDoacoes_TB_GIVEWIN_DOACAO_DoacaoId",
                table: "DoacaoTipoDoacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_DoacaoTipoDoacoes_TB_GIVEWIN_TIPO_DOACAO_TipoDoacaoId",
                table: "DoacaoTipoDoacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoacaoTipoDoacoes",
                table: "DoacaoTipoDoacoes");

            migrationBuilder.RenameTable(
                name: "DoacaoTipoDoacoes",
                newName: "DoacoesTiposDoacao");

            migrationBuilder.RenameIndex(
                name: "IX_DoacaoTipoDoacoes_TipoDoacaoId",
                table: "DoacoesTiposDoacao",
                newName: "IX_DoacoesTiposDoacao_TipoDoacaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoacoesTiposDoacao",
                table: "DoacoesTiposDoacao",
                columns: new[] { "DoacaoId", "TipoDoacaoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoacoesTiposDoacao_TB_GIVEWIN_DOACAO_DoacaoId",
                table: "DoacoesTiposDoacao",
                column: "DoacaoId",
                principalTable: "TB_GIVEWIN_DOACAO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoacoesTiposDoacao_TB_GIVEWIN_TIPO_DOACAO_TipoDoacaoId",
                table: "DoacoesTiposDoacao",
                column: "TipoDoacaoId",
                principalTable: "TB_GIVEWIN_TIPO_DOACAO",
                principalColumn: "TipoDoacaoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoacoesTiposDoacao_TB_GIVEWIN_DOACAO_DoacaoId",
                table: "DoacoesTiposDoacao");

            migrationBuilder.DropForeignKey(
                name: "FK_DoacoesTiposDoacao_TB_GIVEWIN_TIPO_DOACAO_TipoDoacaoId",
                table: "DoacoesTiposDoacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoacoesTiposDoacao",
                table: "DoacoesTiposDoacao");

            migrationBuilder.RenameTable(
                name: "DoacoesTiposDoacao",
                newName: "DoacaoTipoDoacoes");

            migrationBuilder.RenameIndex(
                name: "IX_DoacoesTiposDoacao_TipoDoacaoId",
                table: "DoacaoTipoDoacoes",
                newName: "IX_DoacaoTipoDoacoes_TipoDoacaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoacaoTipoDoacoes",
                table: "DoacaoTipoDoacoes",
                columns: new[] { "DoacaoId", "TipoDoacaoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoacaoTipoDoacoes_TB_GIVEWIN_DOACAO_DoacaoId",
                table: "DoacaoTipoDoacoes",
                column: "DoacaoId",
                principalTable: "TB_GIVEWIN_DOACAO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoacaoTipoDoacoes_TB_GIVEWIN_TIPO_DOACAO_TipoDoacaoId",
                table: "DoacaoTipoDoacoes",
                column: "TipoDoacaoId",
                principalTable: "TB_GIVEWIN_TIPO_DOACAO",
                principalColumn: "TipoDoacaoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
