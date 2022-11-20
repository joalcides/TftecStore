using TFTEC.Web.Ecommerce.Context;
using TFTEC.Web.Ecommerce.Models;
using TFTEC.Web.Ecommerce.Repositories.Interfaces;

namespace TFTEC.Web.Ecommerce.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
