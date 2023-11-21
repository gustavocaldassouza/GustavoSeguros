using GustavoSeguros.Application.UseCases.CalcularSeguro;
using GustavoSeguros.Presentation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GustavoSeguros.Presentation.UseCases.CalcularSeguro
{
  [Route("[controller]")]
  [ApiController]
  public class CalcularSeguroController : ControllerBase, IOutputPort
  {
    private readonly ICalcularSeguroUseCase _useCase;
    private IActionResult _viewModel;
    public CalcularSeguroController(ICalcularSeguroUseCase calcularSeguroUseCase)
    {
      _useCase = calcularSeguroUseCase;
      _useCase.SetOutputPort(this);
    }
    void IOutputPort.Invalid()
    {
      _viewModel = BadRequest();
    }

    void IOutputPort.Ok(decimal valor)
    {
      _viewModel = Ok(valor);
    }

    [HttpPost]
    public IActionResult Post([FromBody] VeiculoModel veiculoModel)
    {
      _useCase.Executar(veiculoModel.Valor);
      return _viewModel;
    }
  }
}
