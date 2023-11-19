using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.GravarSeguro
{
  public class GravarSeguroPresenter : IOutputPort
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
