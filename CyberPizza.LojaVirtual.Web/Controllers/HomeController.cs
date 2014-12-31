using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CyberPizza.LojaVirtual.Dominio.Entidades;
using CyberPizza.LojaVirtual.Dominio.Repositorio;

namespace CyberPizza.LojaVirtual.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Logradouro logradouro)
        {
            var logradourosLogradouro = new Logradouro();
         
                var repositorio = new LogradouroRepoitorio();

                IEnumerable<Logradouro> logradouros = repositorio.Logradouros
                    .SqlQuery("Select * from Logradouro where logradouro.cep = " + logradouro.Cep + "");

                if (!logradouros.Any())
                {
                    ViewData["TextoMsg"] = "Atenção ! Cep "+logradouro.Cep+" Inválido";
                    ViewData["TipoMsg"] = 3;
                    return View("Index", logradourosLogradouro);
                }
                foreach (var item in logradouros)
                {
                    logradourosLogradouro.Cep = item.Cep;
                    logradourosLogradouro.Bairro = item.Bairro;
                    logradourosLogradouro.Cidade = item.Cidade;
                    logradourosLogradouro.Endereco = item.Endereco;
                    logradourosLogradouro.Estado = item.Estado;
                    logradourosLogradouro.Ukey = item.Ukey;
                }

                ViewData["TextoMsg"] = " Disponível ! Cep " + logradouro.Cep;
                ViewData["TipoMsg"] = 1;
                ViewData["Url"] = "Vitrine/ListaProdutos";
                ViewData["UrlTexto"] = " Para continuar click aqui";
            return View("Index", logradourosLogradouro);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}