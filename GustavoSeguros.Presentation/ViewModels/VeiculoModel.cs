using GustavoSeguros.Domain;
using System.ComponentModel.DataAnnotations;

namespace GustavoSeguros.Presentation.ViewModels
{
  public class VeiculoModel
  {
    public int Id { get; set; }
    public float Valor { get; set; }
    public string Modelo { get; set; }
    public VeiculoModel(Veiculo veiculo)
    {
      Id = veiculo.Id;
      Valor = veiculo.Valor;
      Modelo = veiculo.Modelo;
    }

    public VeiculoModel()
    {

    }

    public Veiculo ToVeiculo()
    {
      var veiculo = new Veiculo(Id, Valor, Modelo);
      return veiculo;
    }
  }
}
