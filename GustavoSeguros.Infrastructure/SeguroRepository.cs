using GustavoSeguros.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GustavoSeguros.Infrastructure
{
  public class SeguroRepository : ISeguroRepository
  {
    public void Add(Seguro seguro)
    {
      using (var context = new MyDbContext())
      {
        context.Seguros.Add(seguro);
        context.SaveChanges();
      }
    }

    public Seguro Get(int id)
    {
      using (var context = new MyDbContext())
      {
        return context.Seguros.Include(p => p.Veiculo)
                              .Include(p => p.Segurado)
                              .FirstOrDefault(s => s.Id == id);
      }
    }

    public SeguroCollection GetCollection()
    {
      var collection = new SeguroCollection();
      using (var context = new MyDbContext())
      {
        collection.seguros = context.Seguros.Include(p => p.Veiculo).Include(p => p.Segurado).ToList();
      }
      return collection;
    }
  }
}
