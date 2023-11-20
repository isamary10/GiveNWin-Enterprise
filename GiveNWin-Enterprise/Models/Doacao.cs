using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_DOACAO")]
    public class Doacao
    {
        public int Id { get; set; }
        [Required]
        public DateTime DataDoacao { get; set; }
    }
}
