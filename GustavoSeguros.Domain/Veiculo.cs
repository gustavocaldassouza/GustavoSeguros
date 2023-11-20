using System;

namespace GustavoSeguros.Domain
{
  public class Veiculo
  {
    public int Id { get; set; }
    public decimal Valor { get; set; }
    public string Modelo { get; set; }

    public Veiculo()
    {
    }

    public Veiculo(int id, decimal valor, string modelo)
    {
      Id = id;
      Valor = valor;
      Modelo = modelo;
    }

    public bool IsValid()
    {
      return Valor > 0 && Modelo != null;
    }
  }
}
