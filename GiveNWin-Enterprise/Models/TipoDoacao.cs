using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_TIPO_DOCAO")]
    public class TipoDoacao
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public int Pontos { get; set; }
    }
}
