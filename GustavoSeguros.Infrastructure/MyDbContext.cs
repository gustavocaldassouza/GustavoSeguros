using GustavoSeguros.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Infrastructure
{
  public class MyDbContext : DbContext
  {
    public DbSet<Seguro> Seguros { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {

    }
    public MyDbContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=db;Database=myDataBase;User Id=SA;Password=YourPassword123!;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Seguro>().ToTable("SEGURO");
      modelBuilder.Entity<Veiculo>().ToTable("VEICULO").Property(p => p.Modelo).HasMaxLength(30).IsRequired();
      modelBuilder.Entity<Segurado>().ToTable("SEGURADO").Property(p => p.Nome).HasMaxLength(50).IsRequired();
      modelBuilder.Entity<Segurado>().ToTable("SEGURADO").Property(p => p.CPF).HasMaxLength(11).IsRequired();
    }
  }
}
