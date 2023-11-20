using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace GustavoSeguros.Application.UseCases.GravarSeguro
{
  public interface IGravarSeguroUseCase
  {
    void Executar(Seguro seguro);
    void SetOutputPort(IOutputPort outputPort);
  }
}