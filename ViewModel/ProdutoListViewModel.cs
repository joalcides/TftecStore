using TFTEC.Web.Ecommerce.Models;

namespace TFTEC.Web.Ecommerce.ViewModel
{
    public class ProdutoListViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
