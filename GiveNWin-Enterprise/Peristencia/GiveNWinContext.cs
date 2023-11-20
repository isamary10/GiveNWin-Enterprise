﻿using GiveNWin_Enterprise.Models;
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
        public GiveNWinContext(DbContextOptions options) : base(options) { }
    }
}
