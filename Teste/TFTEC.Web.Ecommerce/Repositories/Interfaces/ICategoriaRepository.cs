using TFTEC.Web.Ecommerce.Models;

namespace TFTEC.Web.Ecommerce.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }

}

