using Microsoft.AspNetCore.Mvc;
using TFTEC.Web.Ecommerce.Models;
using TFTEC.Web.Ecommerce.Repositories;
using TFTEC.Web.Ecommerce.Repositories.Interfaces;
using TFTEC.Web.Ecommerce.ViewModel;

namespace TFTEC.Web.Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.Produtos.OrderBy(l => l.ProdutoId);
                categoriaAtual = "Todos os Produtos";
            }
            else
            {
                produtos = _produtoRepository.Produtos
                          .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                          .OrderBy(c => c.NomeProduto);

                categoriaAtual = categoria;
            }

            var produtoListViewModel = new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            };

            return View(produtoListViewModel);
        }

        public IActionResult Details(int produtoId)
        {
            var produto = _produtoRepository.Produtos.FirstOrDefault(l => l.ProdutoId == produtoId);
            return View(produto);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
                categoriaAtual = "Todos os Produtos TFTEC";
            }
            else
            {
               produtos = _produtoRepository.Produtos
                          .Where(p => p.NomeProduto.ToLower().Contains(searchString.ToLower()));

                if (produtos.Any())
                    categoriaAtual = "Produtos";
                else
                    categoriaAtual = "Nenhum produto foi encontrado";
            }

            return View("~/Views/Produto/List.cshtml", new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            });
        }
    }
}
