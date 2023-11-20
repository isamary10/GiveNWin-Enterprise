using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
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

            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_DOACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDoacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_DOACAO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_DOADOR",
                columns: table => new
                {
                    DoadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dt_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pontuacao = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_DOADOR", x => x.DoadorId);
                });

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

            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_PARCEIRO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razao_Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_PARCEIRO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_TIPO_DOACAO",
                columns: table => new
                {
                    TipoDoacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pontos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_TIPO_DOACAO", x => x.TipoDoacaoId);
                });

            migrationBuilder.CreateTable(
                name: "TB_GIVEWIN_RECEPTOR",
                columns: table => new
                {
                    ReceptorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razao_Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GIVEWIN_RECEPTOR", x => x.ReceptorId);
                    table.ForeignKey(
                        name: "FK_TB_GIVEWIN_RECEPTOR_TB_GIVEWIN_ENDERECO_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "TB_GIVEWIN_ENDERECO",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_GIVEWIN_RECEPTOR_EnderecoId",
                table: "TB_GIVEWIN_RECEPTOR",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_CUPOM");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_DOACAO");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_DOADOR");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_PARCEIRO");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_RECEPTOR");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_TIPO_DOACAO");

            migrationBuilder.DropTable(
                name: "TB_GIVEWIN_ENDERECO");
        }
    }
}
