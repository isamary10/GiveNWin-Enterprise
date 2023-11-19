using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_DOADOR")]
    public class Doador
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        [Column("Dt_Nascimento"), Required, DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int Pontuacao { get; set; }
    }
}
