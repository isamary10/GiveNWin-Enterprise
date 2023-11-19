using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_PARCEIRO")]
    public class Parceiros
    {
        public int Id { get; set; }
        [Column("Razao_Social"), Required]
        public string? RazaoSocial { get; set; }
        [Column("Nome_Fantasia")]
        public string? NomeFantasia { get; set; }
        [Required]
        public string? Cnpj { get; set; }
    }
}
