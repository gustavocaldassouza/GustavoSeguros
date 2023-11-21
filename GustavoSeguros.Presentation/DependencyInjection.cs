using GustavoSeguros.Application.UseCases;
using GustavoSeguros.Application.UseCases.CalcularSeguro;
using GustavoSeguros.Application.UseCases.GerarRelatorio;
using GustavoSeguros.Application.UseCases.GravarSeguro;
using GustavoSeguros.Application.UseCases.PesquisarSeguro;
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

      services.AddScoped<ICalcularSeguroUseCase, CalcularSeguroUseCase>();

      services.AddScoped<IGerarRelatorioUseCase, GerarRelatorioUseCase>();

      services.AddScoped<IPesquisarSeguroUseCase, PesquisarSeguroUseCase>();

      return services;
    }
  }
}
