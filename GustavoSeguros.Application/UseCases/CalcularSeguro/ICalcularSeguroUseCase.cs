using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GustavoSeguros.Application.UseCases.CalcularSeguro
{
  public interface ICalcularSeguroUseCase
  {
    void Executar(decimal valorVeiculo);
    void SetOutputPort(IOutputPort outputPort);
  }
}
