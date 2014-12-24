using System.Web.Mvc;

namespace CyberPizza.LojaVirtual.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult LogoutUser()
        {
            Session.Remove("Logado");
            return View("~/views/Home/Index.cshtml");
        }

    }
}