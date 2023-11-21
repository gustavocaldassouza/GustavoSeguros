using GustavoSeguros.Application.UseCases.PesquisarSeguro;
using GustavoSeguros.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GustavoSeguros.Presentation.UseCases.PesquisarSeguro
{
  [Route("[controller]")]
  [ApiController]
  public class PesquisarSeguroController : ControllerBase, IOutputPort
  {
    private readonly IPesquisarSeguroUseCase _useCase;
    private IActionResult _viewModel;
    public PesquisarSeguroController(IPesquisarSeguroUseCase pesquisarSeguroUseCase)
    {
      _useCase = pesquisarSeguroUseCase;
      _useCase.SetOutputPort(this);
    }
    void IOutputPort.Invalid()
    {
      _viewModel = BadRequest();
    }

    void IOutputPort.Ok(Seguro seguro)
    {
      _viewModel = Ok(seguro);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      _useCase.Executar(id);
      return _viewModel;
    }
  }
}
