using System;

namespace GustavoSeguros.Domain
{
  public class Veiculo
  {
    public int Id { get; set; }
    public float Valor { get; set; }
    public string Modelo { get; set; }

    public Veiculo()
    {
    }

    public Veiculo(int id, float valor, string modelo)
    {
      Id = id;
      Valor = valor;
      Modelo = modelo;
    }
  }
}
