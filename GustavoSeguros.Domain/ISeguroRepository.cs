using System;
using System.Collections.Generic;
using System.Text;

namespace GustavoSeguros.Domain
{
  public interface ISeguroRepository
  {
    void Add(Seguro seguro);
    Seguro Get(int id);
    SeguroCollection GetCollection();
  }
}
