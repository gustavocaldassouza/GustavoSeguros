﻿using GustavoSeguros.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Application.UseCases.CalcularSeguro
{
  public class CalcularSeguroPresenter : IOutputPort
  {
    public decimal Valor { get; private set; }
    public bool InvalidOutput { get; private set; }
    public void Invalid()
    {
      this.InvalidOutput = true;
    }

    public void Ok(decimal valor)
    {
      Valor = valor;
    }
  }
}
