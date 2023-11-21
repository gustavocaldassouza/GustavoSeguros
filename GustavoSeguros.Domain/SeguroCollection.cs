using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GustavoSeguros.Domain
{
  public sealed class SeguroCollection
  {
    public decimal MediaAritmetica { get; set; }
    public List<Seguro> seguros { get; set; }
  }
}
