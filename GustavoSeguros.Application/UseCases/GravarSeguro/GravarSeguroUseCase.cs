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
    private IOutputPort _outputPort;
    public GravarSeguroUseCase(ISeguroRepository seguroRepository)
    {
      _seguroRepository = seguroRepository;
      _outputPort = new GravarSeguroPresenter();
    }
    public void Executar(Seguro seguro)
    {
      // Gravar os dados de um Seguro em banco de dados relacional
      _seguroRepository.Add(seguro);
      //Rodou no banco!
      _outputPort.Ok(seguro);
    }

    public void SetOutputPort(IOutputPort outputPort)
    {
      _outputPort = outputPort;
    }
  }
}
