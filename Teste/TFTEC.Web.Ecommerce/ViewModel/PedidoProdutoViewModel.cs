using TFTEC.Web.Ecommerce.Models;

namespace TFTEC.Web.Ecommerce.ViewModel
{
    public class PedidoProdutoViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
