using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace GustavoSeguros.Application.UseCases.GravarSeguro
{
  public class GravarSeguroUseCase : IGravarSeguroUseCase
  {
    private readonly ISeguroRepository _seguroRepository;
    private IOutputPort OutputPort { get; set; }
    public GravarSeguroUseCase(ISeguroRepository seguroRepository)
    {
      _seguroRepository = seguroRepository;
      OutputPort = new GravarSeguroPresenter();
    }
    public void Executar(Seguro seguro)
    {
      try
      {
        if (seguro.Segurado.IsValid() && seguro.Veiculo.IsValid())
        {
          _seguroRepository.Add(seguro);
          OutputPort.Ok(seguro);
          return;
        }
        OutputPort.Invalid();
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
