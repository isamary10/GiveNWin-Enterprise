namespace GiveNWin_Enterprise.Models
{
    public class Doador
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime? dataNascimento { get; set; }
        public string? email { get; set; }
        public int pontuacao { get; set; }
    }
}
