using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_CUPOM")]
    public class Cupom
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Column("Vl_Desconto"), Required, Display(Name = "Valor Desconto")]
        public double ValorDesconto { get; set; }
        [Required]
        public Boolean Disponibilidade { get; set; }
        [Column("Codigo_Desconto"), Required, Display(Name = "Codigo Desconto")]
        public string? CodigoDesconto { get; set; }
    }
}
