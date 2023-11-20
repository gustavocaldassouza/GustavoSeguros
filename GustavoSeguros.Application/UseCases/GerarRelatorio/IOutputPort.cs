using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.GerarRelatorio
{
  public interface IOutputPort
  {
    void Ok(SeguroCollection seguros);
    void Invalid();
  }
}
