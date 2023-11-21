using GustavoSeguros.Application.UseCases.GerarRelatorio;
using GustavoSeguros.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GustavoSeguros.Presentation.UseCases.GerarRelatorio
{
  [Route("[controller]")]
  [ApiController]
  public class GerarRelatorioController : ControllerBase, IOutputPort
  {
    private IActionResult _viewModel;
    private readonly IGerarRelatorioUseCase _useCase;
    public GerarRelatorioController(IGerarRelatorioUseCase gerarRelatorioUseCase)
    {
      _useCase = gerarRelatorioUseCase;
      _useCase.SetOutputPort(this);
    }
    void IOutputPort.Invalid()
    {
      _viewModel = BadRequest();
    }

    void IOutputPort.Ok(SeguroCollection seguros)
    {
      _viewModel = Ok(seguros);
    }

    [HttpGet]
    public IActionResult Get()
    {
      _useCase.Executar();
      return _viewModel;
    }
  }
}
