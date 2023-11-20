using GustavoSeguros.Domain;
using System.ComponentModel.DataAnnotations;

namespace GustavoSeguros.Presentation.ViewModels
{
  public class SeguroModel
  {
    public int Id { get; set; }
    public VeiculoModel VeiculoModel { get; set; }
    public SeguradoModel SeguradoModel { get; set; }
    public SeguroModel(Seguro seguro)
    {
      Id = seguro.Id;
      VeiculoModel = new VeiculoModel(seguro.Veiculo);
      SeguradoModel = new SeguradoModel(seguro.Segurado);
    }
    public SeguroModel()
    {

    }
    public Seguro ToSeguro()
    {
      var seguro = new Seguro(Id, VeiculoModel.ToVeiculo(), SeguradoModel.ToSegurado());
      return seguro;
    }
  }
}
