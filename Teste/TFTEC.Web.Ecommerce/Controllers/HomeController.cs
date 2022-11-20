using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TFTEC.Web.Ecommerce.Models;
using TFTEC.Web.Ecommerce.Repositories.Interfaces;
using TFTEC.Web.Ecommerce.ViewModel;

namespace TFTEC.Web.Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProdutosEstoque = _produtoRepository.ProdutoEstoque
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id
                ?? HttpContext.TraceIdentifier
            });
        }
    }
}