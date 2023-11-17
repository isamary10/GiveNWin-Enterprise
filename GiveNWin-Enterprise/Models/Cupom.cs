namespace GiveNWin_Enterprise.Models
{
    public class Cupom
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public double valorDesconto { get; set; }
        public Boolean disponibilidade { get; set; }
        public string codigoGerado { get; set; }
    }
}
