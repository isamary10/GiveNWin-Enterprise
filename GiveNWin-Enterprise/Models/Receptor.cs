using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_RECEPTOR")]
    public class Receptor
    {
        [HiddenInput]
        public int ReceptorId { get; set; }
        [Column("Razao_Social"), Required, Display(Name = "Razão Social")]
        public string? RazaoSocial { get; set; }
        [Column("Nome_Fantasia"), Display(Name = "Nome Fantasia")]
        public string? NomeFantasia { get; set; }
        [Required]
        public string? Cnpj { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
    }
}
