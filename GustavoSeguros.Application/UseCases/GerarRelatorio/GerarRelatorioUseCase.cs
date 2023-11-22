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
        decimal somaCalculoSeguro = 0;
        foreach (var seg in seguros.seguros)
        {
          somaCalculoSeguro += _calculoSeguro.Calcular(seg.Veiculo.Valor);
        }
        if (seguros.seguros.Count > 0)
        {
          seguros.MediaAritmetica = somaCalculoSeguro / seguros.seguros.Count;
        }
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
