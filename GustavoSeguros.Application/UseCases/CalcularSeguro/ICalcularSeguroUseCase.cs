using GustavoSeguros.Application.UseCases.CalcularSeguro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GustavoSeguros.Application.UseCases
{
  public interface ICalcularSeguroUseCase
  {
    void Executar(float valorVeiculo);
    void SetOutputPort(IOutputPort outputPort);
  }
}
