using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Domain
{
  public class Segurado
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public int Idade { get; set; }

    public Segurado()
    {
    }

    public Segurado(string nome, string cPF, int idade)
    {
      Nome = nome;
      CPF = cPF;
      Idade = idade;
    }

    public bool IsValid()
    {
      return Nome != null && CPF != null && Idade > 18;
    }
  }
}
