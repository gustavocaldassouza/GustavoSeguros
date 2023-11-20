using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.CalcularSeguro
{
  public interface IOutputPort
  {
    void Ok(decimal valor);
    void Invalid();
  }
}
