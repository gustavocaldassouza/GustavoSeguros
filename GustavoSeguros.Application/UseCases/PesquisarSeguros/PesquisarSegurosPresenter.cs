using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.PesquisarSeguros
{
  public class PesquisarSegurosPresenter : IOutputPort
  {
    public Seguro Seguro { get; private set; }
    public bool InvalidOutput { get; private set; }
    public void Invalid()
    {
      this.InvalidOutput = true;
    }

    public void Ok(Seguro seguro)
    {
      Seguro = seguro;
    }
  }
}
