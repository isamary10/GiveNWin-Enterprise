﻿// <auto-generated />
using System;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    [DbContext(typeof(GiveNWinContext))]
    [Migration("20231122010029_updateDoacao")]
    partial class updateDoacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Cupom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoDesconto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Codigo_Desconto");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("bit");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("ValorDesconto")
                        .HasColumnType("float")
                        .HasColumnName("Vl_Desconto");

                    b.HasKey("Id");

                    b.ToTable("TB_GIVEWIN_CUPOM");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Doacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDoacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoadorId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoadorId");

                    b.HasIndex("ReceptorId");

                    b.ToTable("TB_GIVEWIN_DOACAO");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.DoacaoTipoDoacao", b =>
                {
                    b.Property<int>("DoacaoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDoacaoId")
                        .HasColumnType("int");

                    b.HasKey("DoacaoId", "TipoDoacaoId");

                    b.HasIndex("TipoDoacaoId");

                    b.ToTable("DoacoesTiposDoacao");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Doador", b =>
                {
                    b.Property<int>("DoadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoadorId"));

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.HasKey("DoadorId");

                    b.ToTable("TB_GIVEWIN_DOADOR");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecoId");

                    b.ToTable("TB_GIVEWIN_ENDERECO");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Parceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome_Fantasia");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Razao_Social");

                    b.HasKey("Id");

                    b.ToTable("TB_GIVEWIN_PARCEIRO");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Receptor", b =>
                {
                    b.Property<int>("ReceptorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptorId"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome_Fantasia");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Razao_Social");

                    b.HasKey("ReceptorId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("TB_GIVEWIN_RECEPTOR");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.TipoDoacao", b =>
                {
                    b.Property<int>("TipoDoacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoDoacaoId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pontos")
                        .HasColumnType("int");

                    b.HasKey("TipoDoacaoId");

                    b.ToTable("TB_GIVEWIN_TIPO_DOACAO");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Doacao", b =>
                {
                    b.HasOne("GiveNWin_Enterprise.Models.Doador", "Doador")
                        .WithMany("Doacoes")
                        .HasForeignKey("DoadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiveNWin_Enterprise.Models.Receptor", "Receptor")
                        .WithMany("Doacoes")
                        .HasForeignKey("ReceptorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doador");

                    b.Navigation("Receptor");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.DoacaoTipoDoacao", b =>
                {
                    b.HasOne("GiveNWin_Enterprise.Models.Doacao", "Doacao")
                        .WithMany("DoacoesTiposDoacao")
                        .HasForeignKey("DoacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiveNWin_Enterprise.Models.TipoDoacao", "TipoDoacao")
                        .WithMany("DoacoesTiposDoacao")
                        .HasForeignKey("TipoDoacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doacao");

                    b.Navigation("TipoDoacao");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Receptor", b =>
                {
                    b.HasOne("GiveNWin_Enterprise.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Doacao", b =>
                {
                    b.Navigation("DoacoesTiposDoacao");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Doador", b =>
                {
                    b.Navigation("Doacoes");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Receptor", b =>
                {
                    b.Navigation("Doacoes");
                });

            modelBuilder.Entity("GiveNWin_Enterprise.Models.TipoDoacao", b =>
                {
                    b.Navigation("DoacoesTiposDoacao");
                });
#pragma warning restore 612, 618
        }
    }
}
