using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCheckout.App
{
    public class PedidoService
    {
        public string GerarCodigoRastreio(string regiao, int numeroPedido)
        {
            return $"{regiao.ToUpperInvariant()}-{numeroPedido:D4}";
        }

        public int CalcularPontosFidelidade(decimal valorCompra)
        {
            return (int)(valorCompra / 10m);
        }

        public bool TemFreteGratis(decimal valorPedido, bool clienteVip)
        {
            return clienteVip || valorPedido >= 200m;
        }
    }
}