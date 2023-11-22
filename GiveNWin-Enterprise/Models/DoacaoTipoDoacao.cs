namespace GiveNWin_Enterprise.Models
{
    public class DoacaoTipoDoacao
    {
        public int DoacaoId { get; set; }
        public Doacao Doacao { get; set; }
        public int TipoDoacaoId { get; set; }
        //public int Pontos { get; set; }
        public TipoDoacao TipoDoacao { get; set; }
    }
}
