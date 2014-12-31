using System.Linq;
using System.Web.Mvc;
using CyberPizza.LojaVirtual.Dominio.Repositorio;
using CyberPizza.LojaVirtual.Web.Models;

namespace CyberPizza.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 2;
        // GET: Vitrine
           public ViewResult ListaProdutos(string categoria = null, int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();
               
               var model = new ProdutosViewModel
               {
                   Produtos = _repositorio.Produtos
                       .Where(p => categoria == null || p.Categoria == categoria)
                       .OrderBy(p => p.Nome)
                       .Skip((pagina - 1)*ProdutosPorPagina)
                       .Take(ProdutosPorPagina),
                   Paginacao = new Paginacao()
                   {
                       PaginaAtual = pagina,
                       ItensPorPagina = ProdutosPorPagina,
                       ItensTotal = _repositorio.Produtos.Count(p => categoria == null || p.Categoria == categoria)
                   },
                   CategoriaAtual = categoria
               };
            
            return View(model);
        }
    }
}