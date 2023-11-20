using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.Common
{
  public class CalculoSeguro
  {
    private const float MARGEM_SEGURANCA = .03f;
    private const float LUCRO = .05f;

    public float Calcular(float valorVeiculo)
    {
      float taxaDeRisco = valorVeiculo * 5 / valorVeiculo * 2;
      float premioDeRisco = taxaDeRisco * valorVeiculo;
      float premioPuro = premioDeRisco * (1 + MARGEM_SEGURANCA);
      float premioComercial = LUCRO * premioPuro;
      return premioComercial;
    }
  }
}
