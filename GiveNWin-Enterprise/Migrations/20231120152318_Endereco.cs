using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    /// <inheritdoc />
    public partial class Endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_ENDERECO",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_ENDERECO", x => x.EnderecoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_GIVEWIN_RECEPTOR_EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_GIVEWIN_RECEPTOR_TB_GIVEWIN_ENDERECO_EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR",
                column: "EnderecoId",
                principalTable: "TB_GIVEWIN_ENDERECO",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_GIVEWIN_RECEPTOR_TB_GIVEWIN_ENDERECO_EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_ENDERECO");

            migrationBuilder.DropIndex(
                name: "IX_TB_GIVEWIN_RECEPTOR_EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR");
        }
    }
}
