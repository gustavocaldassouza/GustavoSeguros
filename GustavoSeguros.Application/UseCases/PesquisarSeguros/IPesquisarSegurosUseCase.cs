using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.PesquisarSeguros
{
  public interface IPesquisarSegurosUseCase
  {
    void Executar(int id);
    void SetOutputPort(IOutputPort outputPort);
  }
}
