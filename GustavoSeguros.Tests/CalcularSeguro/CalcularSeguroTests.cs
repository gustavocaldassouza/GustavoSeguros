using GustavoSeguros.Application.UseCases.CalcularSeguro;
using NUnit.Framework;

namespace GustavoSeguros.Tests.CalcularSeguro
{
  [TestFixture]
  public class CalcularSeguroTests
  {
    private ICalcularSeguroUseCase _calcularSeguroUseCase;
    private CalcularSeguroPresenter _calcularSeguroPresenter;
    [SetUp]
    public void SetUp()
    {
      _calcularSeguroUseCase = new CalcularSeguroUseCase();
      _calcularSeguroPresenter = new CalcularSeguroPresenter();
    }

    [TearDown]
    public void TearDown()
    {
      // Cleanup code, if needed
    }

    [Test]
    [TestCase(10000, 270.37)]
    [TestCase(20000, 540.75)]
    public void CalcularSeguro(decimal valorVeiculo, decimal expected)
    {
      // Arrange
      _calcularSeguroUseCase.SetOutputPort(_calcularSeguroPresenter);

      // Act
      _calcularSeguroUseCase.Executar(valorVeiculo);

      // Assert
      Assert.AreEqual(expected, _calcularSeguroPresenter.Valor);
    }
  }
}
