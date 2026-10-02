using EcommerceCheckout.App;
using Xunit;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
  private readonly PedidoService _pedidoService = new();

  [Fact]
  public void GerarCodigoRastreio_DeveFormatarRegiaoENumeroComZeros()
  {
    var resultado = _pedidoService.GerarCodigoRastreio("sudeste", 42);

    Assert.Equal("SUDESTE-0042", resultado);
  }

  [Fact]
  public void CalcularPontosFidelidade_DeveRetornar30PontosParaCompraDe300Reais()
  {
    var resultado = _pedidoService.CalcularPontosFidelidade(300m);

    Assert.Equal(30, resultado);
  }

  [Fact]
  public void TemFreteGratis_DeveRetornarTrueParaClienteVipAbaixoDe200Reais()
  {
    var resultado = _pedidoService.TemFreteGratis(100m, clienteVip: true);

    Assert.True(resultado);
  }

  [Fact]
  public void TemFreteGratis_DeveRetornarFalseParaClienteNaoVipAbaixoDe200Reais()
  {
    var resultado = _pedidoService.TemFreteGratis(100m, clienteVip: false);

    Assert.False(resultado);
  }
}
