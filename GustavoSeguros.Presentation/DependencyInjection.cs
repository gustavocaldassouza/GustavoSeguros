using GustavoSeguros.Application.UseCases;
using GustavoSeguros.Application.UseCases.GravarSeguro;
using GustavoSeguros.Domain;
using GustavoSeguros.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace GustavoSeguros.Presentation
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
      services.AddScoped<IGravarSeguroUseCase, GravarSeguroUseCase>();
      services.AddScoped<ISeguroRepository, SeguroRepository>();

      return services;
    }
  }
}
