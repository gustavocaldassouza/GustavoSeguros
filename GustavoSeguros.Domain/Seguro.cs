using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Domain
{
  public class Seguro
  {
    public int Id { get; set; }
    public Veiculo Veiculo { get; set; }
    public Segurado Segurado { get; set; }

    public Seguro()
    {

    }

    public Seguro(int id, Veiculo veiculo, Segurado segurado)
    {
      Id = id;
      Veiculo = veiculo;
      Segurado = segurado;
    }
  }
}
