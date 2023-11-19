using GustavoSeguros.Domain;
using System.ComponentModel.DataAnnotations;

namespace GustavoSeguros.Presentation.ViewModels
{
  public class SeguroModel
  {
    [Required]
    public int Id { get; }
    [Required]
    public string Veiculo { get; }
    [Required]
    public string Segurado { get; }
    public SeguroModel(Seguro seguro)
    {
      Id = seguro.Id;
      //Veiculo = seguro.Veiculo.Modelo;
      //Veiculo = seguro.Segurado.Nome;
    }
  }
}
