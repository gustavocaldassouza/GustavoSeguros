using GustavoSeguros.Application.Common;
using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.GerarRelatorio
{
  public sealed class GerarRelatorioUseCase : IGerarRelatorioUseCase
  {
    private IOutputPort OutputPort { get; set; }
    private readonly ISeguroRepository _seguroRepository;
    private readonly CalculoSeguro _calculoSeguro;
    public GerarRelatorioUseCase(ISeguroRepository seguroRepository)
    {
      OutputPort = new GerarRelatorioPresenter();
      _seguroRepository = seguroRepository;
      _calculoSeguro = new CalculoSeguro();
    }
    public void Executar()
    {
      try
      {
        var seguros = _seguroRepository.GetCollection();
        decimal mediaAritmetica = 0;
        foreach (var seg in seguros.seguros)
        {
          mediaAritmetica += _calculoSeguro.Calcular(seg.Veiculo.Valor);
        }
        seguros.MediaAritmetica = mediaAritmetica;
        OutputPort.Ok(seguros);
      }
      catch (Exception e)
      {
        OutputPort.Invalid();
        throw e;
      }
    }

    public void SetOutputPort(IOutputPort outputPort)
    {
      OutputPort = outputPort;
    }
  }
}
