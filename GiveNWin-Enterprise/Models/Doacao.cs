using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_DOACAO")]
    public class Doacao
    {
        public int Id { get; set; }
        [Required, Display(Name = "Data Doação"), DataType(DataType.Date)]
        public DateTime DataDoacao { get; set; }

        // Relacionamento 1:N com Receptor
        [Display(Name = "Receptor")]
        public int ReceptorId { get; set; }
        public Receptor Receptor { get; set; }


        // Relacionamento 1:N com Doador
        [Display(Name = "Doador")]
        public int DoadorId { get; set; }
        public Doador Doador { get; set; }

        // Relacionamento N:M com TipoDoacao
        [Display(Name = "Tipo Doação")]
        public IList<DoacaoTipoDoacao> DoacoesTiposDoacao { get; set; }
    }
}
