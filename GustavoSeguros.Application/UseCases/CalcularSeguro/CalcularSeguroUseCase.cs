using GustavoSeguros.Application.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GustavoSeguros.Application.UseCases.CalcularSeguro
{
  public class CalcularSeguroUseCase : ICalcularSeguroUseCase
  {
    private IOutputPort OutputPort { get; set; }
    private readonly CalculoSeguro _calculoSeguro;
    public CalcularSeguroUseCase()
    {
      OutputPort = new CalcularSeguroPresenter();
      _calculoSeguro = new CalculoSeguro();
    }

    public void Executar(float valorVeiculo)
    {
      try
      {
        var premioComercial = _calculoSeguro.Calcular(valorVeiculo);
        OutputPort.Ok(premioComercial);
      }
      catch (Exception e)
      {
        throw e;
      }
    }

    public void SetOutputPort(IOutputPort outputPort)
    {
      OutputPort = outputPort;
    }
  }
}
