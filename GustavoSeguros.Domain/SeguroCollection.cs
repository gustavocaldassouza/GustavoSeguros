using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GustavoSeguros.Domain
{
  public sealed class SeguroCollection : List<Seguro>
  {
    public float MediaAritmetica { get; set; }
  }
}
