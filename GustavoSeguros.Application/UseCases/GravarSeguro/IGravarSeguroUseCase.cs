using GustavoSeguros.Application.UseCases.GravarSeguro;
using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace GustavoSeguros.Application.UseCases
{
  public interface IGravarSeguroUseCase
  {
    void Executar(Seguro seguro);
    void SetOutputPort(IOutputPort outputPort);
  }
}
