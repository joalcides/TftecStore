using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TFTEC.Web.Ecommerce.Models;

namespace TFTEC.Web.Ecommerce.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<ListaPreco> ListaPreco { get; set; }

        public DbSet<ItensListaPreco> ItensListaPreco { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
