using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.PesquisarSeguro
{
  public interface IPesquisarSeguroUseCase
  {
    void Executar(int id);
    void SetOutputPort(IOutputPort outputPort);
  }
}
