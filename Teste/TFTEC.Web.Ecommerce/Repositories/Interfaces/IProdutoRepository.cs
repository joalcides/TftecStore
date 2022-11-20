using TFTEC.Web.Ecommerce.Models;

namespace TFTEC.Web.Ecommerce.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutoEstoque { get; }
        Produto GetProdutoById(int produtoId);
    }
}
