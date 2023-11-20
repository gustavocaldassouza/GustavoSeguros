using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.GerarRelatorio
{
  public interface IGerarRelatorioUseCase
  {
    void Executar();
    void SetOutputPort(IOutputPort outputPort);
  }
}
