using GiveNWin_Enterprise.Models;
using Microsoft.EntityFrameworkCore;

namespace GiveNWin_Enterprise.Peristencia
{
    public class GiveNWinContext : DbContext
    {
        public DbSet<Cupom> Cupons { get; set; }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        public DbSet<Receptor> Receptores { get; set; }
        public DbSet<TipoDoacao> TipoDoacoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<DoacaoTipoDoacao> DoacoesTiposDoacao { get; set; }
        public GiveNWinContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoacaoTipoDoacao>()
                .HasKey(dtd => new { dtd.DoacaoId, dtd.TipoDoacaoId });

            //Configurar a relação da tabela associativa com o Doacao
            modelBuilder.Entity<DoacaoTipoDoacao>()
                .HasOne(d => d.Doacao)
                .WithMany(d => d.DoacoesTiposDoacao)
                .HasForeignKey(d => d.DoacaoId);

            //Configurar a relação da tabela associativa com o TipoDoacao
            modelBuilder.Entity<DoacaoTipoDoacao>()
                .HasOne(td => td.TipoDoacao)
                .WithMany(td => td.DoacoesTiposDoacao)
                .HasForeignKey(td => td.TipoDoacaoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
