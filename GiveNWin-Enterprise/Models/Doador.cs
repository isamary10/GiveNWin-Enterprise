using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveNWin_Enterprise.Models
{
    [Table("TB_GIVEWIN_DOADOR")]
    public class Doador
    {
        [HiddenInput]
        public int DoadorId { get; set; }
        [Required]
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        [Column("Dt_Nascimento"), Required, DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int Pontuacao { get; set; }
        [Required]
        public Genero Genero { get; set; }
        [Required]
        public Estado Estado { get; set; }
        public List<Doacao> Doacoes { get; set; }
    }

    public enum Genero
    {
        Feminino,
        Masculino,
        [Display(Name = "Não Binário")]
        NaoBinario,
        Outros
    }

    public enum Estado
    {
        Acre,
        Alagoas,
        Amapa,
        Amazonas,
        Bahia,
        Ceara,
        [Display(Name = "Distrito Federal")]
        DistritoFederal,
        [Display(Name = "Espirito Santo")]
        EspiritoSanto,
        Goias,
        Maranhao,
        [Display(Name = "Mato Grosso")]
        MatoGrosso,
        [Display(Name = "Mato Grosso do Sul")]
        MatoGrossoDoSul,
        [Display(Name = "Minas Gerais")]
        MinasGerais,
        Para,
        Paraiba,
        Parana,
        Pernambuco,
        Piaui,
        [Display(Name = "Rio de Janeiro")]
        RioDeJaneiro,
        [Display(Name = "Rio Grande do Norte")]
        RioGrandeDoNorte,
        [Display(Name = "Rio Grande do Sul")]
        RioGrandeDoSul,
        Rondonia,
        Roraima,
        [Display(Name = "Santa Catarina")]
        SantaCatarina,
        [Display(Name = "São Paulo")]
        SaoPaulo,
        Sergipe,
        Tocantins,
    }
}
