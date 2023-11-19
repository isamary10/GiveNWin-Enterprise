using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    /// <inheritdoc />
    public partial class BancoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_CUPOM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Vl_Desconto = table.Column<double>(type: "float", nullable: false),
                    Disponibilidade = table.Column<bool>(type: "bit", nullable: false),
                    Codigo_Desconto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_CUPOM", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_CUPOM");
        }
    }
}
