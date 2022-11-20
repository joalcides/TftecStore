using Microsoft.EntityFrameworkCore;
using TFTEC.Web.Ecommerce.Context;
using TFTEC.Web.Ecommerce.Models;
using TFTEC.Web.Ecommerce.Repositories.Interfaces;

namespace TFTEC.Web.Ecommerce.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos => _context.Produto.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutoEstoque => _context.Produto.
                                   Where(l => l.EmEstoque == true)
                                  .Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produto.FirstOrDefault(l => l.ProdutoId == produtoId);
        }
    }
}
