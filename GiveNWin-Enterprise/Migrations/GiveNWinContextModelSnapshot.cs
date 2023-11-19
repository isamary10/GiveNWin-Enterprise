﻿// <auto-generated />
using System;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GiveNWin_Enterprise.Migrations
{
    [DbContext(typeof(GiveNWinContext))]
    partial class GiveNWinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("GiveNWin_Enterprise.Models.Doador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Nascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_GIVEWIN_DOADOR");
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

                    b.ToTable("TB_GIVEWIN_RECEPTOR");
                });
#pragma warning restore 612, 618
        }
    }
}
