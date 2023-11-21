using GustavoSeguros.Application.UseCases.GravarSeguro;
using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.PesquisarSeguro
{
  public class PesquisarSeguroUseCase : IPesquisarSeguroUseCase
  {
    private readonly ISeguroRepository _seguroRepository;
    private IOutputPort OutputPort { get; set; }
    public PesquisarSeguroUseCase(ISeguroRepository seguroRepository)
    {
      _seguroRepository = seguroRepository;
      OutputPort = new PesquisarSeguroPresenter();
    }
    public void Executar(int id)
    {
      try
      {
        var seguro = _seguroRepository.Get(id);
        if (seguro == null)
        {
          OutputPort.Invalid();
        }
        OutputPort.Ok(seguro);
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
