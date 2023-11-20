﻿using GustavoSeguros.Application.Common;
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
        float mediaAritmetica = 0f;
        foreach (var seg in seguros)
        {
          mediaAritmetica += _calculoSeguro.Calcular(seg.Veiculo.Valor);
        }
        OutputPort.Ok(seguros);
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
