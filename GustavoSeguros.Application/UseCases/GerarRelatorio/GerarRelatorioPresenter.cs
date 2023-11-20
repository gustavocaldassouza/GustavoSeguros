using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.GerarRelatorio
{
  public class GerarRelatorioPresenter : IOutputPort
  {
    public SeguroCollection Seguros { get; private set; }
    public bool InvalidOutput { get; private set; }
    public void Invalid()
    {
      this.InvalidOutput = true;
    }

    public void Ok(SeguroCollection seguros)
    {
      Seguros = seguros;
    }
  }
}
