﻿// <auto-generated />
using System;
using GustavoSeguros.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GustavoSeguros.Infrastructure.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231121151057_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GustavoSeguros.Domain.Segurado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Segurado");
                });

            modelBuilder.Entity("GustavoSeguros.Domain.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SeguradoId")
                        .HasColumnType("int");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeguradoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("GustavoSeguros.Domain.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("GustavoSeguros.Domain.Seguro", b =>
                {
                    b.HasOne("GustavoSeguros.Domain.Segurado", "Segurado")
                        .WithMany()
                        .HasForeignKey("SeguradoId");

                    b.HasOne("GustavoSeguros.Domain.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.Navigation("Segurado");

                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
