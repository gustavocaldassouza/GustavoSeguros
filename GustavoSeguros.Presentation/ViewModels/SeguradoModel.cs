using GustavoSeguros.Domain;
using System.ComponentModel.DataAnnotations;

namespace GustavoSeguros.Presentation.ViewModels
{
  public class SeguradoModel
  {
    public int Id { get; }
    [Required] public string Nome { get; set; }
    [Required] public string CPF { get; set; }
    [Required] public int Idade { get; set; }
    public SeguradoModel(Segurado segurado)
    {
      Id = segurado.Id;
      Nome = segurado.Nome;
      CPF = segurado.CPF;
      Idade = segurado.Idade;
    }

    public SeguradoModel()
    {

    }

    public Segurado ToSegurado()
    {
      var segurado = new Segurado(Id, Nome, CPF, Idade);
      return segurado;
    }
  }
}
