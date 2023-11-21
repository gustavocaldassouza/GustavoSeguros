using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.PesquisarSeguro
{
  public interface IOutputPort
  {
    void Ok(Seguro seguro);
    void Invalid();
  }
}
