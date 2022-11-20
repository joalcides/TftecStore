using TFTEC.Web.Ecommerce.Context;
using TFTEC.Web.Ecommerce.Models;

namespace TFTEC.Web.Ecommerce.Areas.Admin.Servicos
{
    public class GraficoVendasService
    {
        private readonly AppDbContext context;

        public GraficoVendasService(AppDbContext context)
        {
            this.context = context;
        }

        public List<ProdutoGrafico> GetVendasLanches(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var produtos = (from pd in context.PedidoDetalhes
                           join l in context.Produto on pd.ProdutoId equals l.ProdutoId
                           where pd.Pedido.PedidoEnviado >= data
                           group pd by new { pd.ProdutoId, l.NomeProduto }
                           into g
                           select new
                           {
                               NomeProduto = g.Key.NomeProduto,
                               QtdeProduto = g.Sum(q => q.Quantidade),
                               ValorFinalProdutos = g.Sum(a => a.Preco * a.Quantidade)
                           });

            var lista = new List<ProdutoGrafico>();

            foreach (var item in produtos)
            {
                var produto = new ProdutoGrafico();
                produto.ProdutoNome = item.NomeProduto;
                produto.QuantidadeProduto = item.QtdeProduto;
                produto.ProdutosValorTotal = item.ValorFinalProdutos;
                lista.Add(produto);
            }
            return lista;
        }
    }
}
