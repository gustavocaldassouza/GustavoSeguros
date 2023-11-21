using GustavoSeguros.Application.UseCases;
using GustavoSeguros.Application.UseCases.GravarSeguro;
using GustavoSeguros.Domain;
using GustavoSeguros.Presentation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GustavoSeguros.Presentation.UseCases.GravarSeguro
{
  [Route("[controller]")]
  [ApiController]
  public class GravarSeguroController : ControllerBase, IOutputPort
  {
    private IActionResult _viewModel;
    private readonly IGravarSeguroUseCase _useCase;
    public GravarSeguroController(IGravarSeguroUseCase useCase)
    {
      _useCase = useCase;
      _useCase.SetOutputPort(this);
    }
    void IOutputPort.Invalid()
    {
      _viewModel = BadRequest();
    }

    void IOutputPort.Ok(Seguro seguro)
    {
      var viewModel = new SeguroModel(seguro);
      _viewModel = Ok(viewModel);
    }

    [HttpPost]
    public IActionResult Post([FromBody]SeguroModel seguroModel)
    {
      _useCase.Executar(seguroModel.ToSeguro());
      return _viewModel;
    }
  }
}
