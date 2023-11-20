using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.Common
{
  public class CalculoSeguro
  {
    private const decimal MARGEM_SEGURANCA = .03M;
    private const decimal LUCRO = .05M;

    public decimal Calcular(decimal valorVeiculo)
    {
      decimal taxaDeRisco = valorVeiculo * 5 / (valorVeiculo * 2);
      decimal premioDeRisco = taxaDeRisco/100 * valorVeiculo;
      decimal premioPuro = premioDeRisco * (1 + MARGEM_SEGURANCA);
      decimal premioComercial = LUCRO * premioPuro;
      return Math.Truncate((premioPuro + premioComercial) * 100) / 100;
    }
  }
}
