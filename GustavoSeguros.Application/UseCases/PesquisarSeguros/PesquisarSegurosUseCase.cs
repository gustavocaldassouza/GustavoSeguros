using GustavoSeguros.Application.UseCases.GravarSeguro;
using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.PesquisarSeguros
{
  public class PesquisarSegurosUseCase : IPesquisarSegurosUseCase
  {
    private readonly ISeguroRepository _seguroRepository;
    private IOutputPort OutputPort { get; set; }
    public PesquisarSegurosUseCase(ISeguroRepository seguroRepository)
    {
      _seguroRepository = seguroRepository;
      OutputPort = new PesquisarSegurosPresenter();
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
        throw e;
      }
    }

    public void SetOutputPort(IOutputPort outputPort)
    {
      OutputPort = outputPort;
    }
  }
}
