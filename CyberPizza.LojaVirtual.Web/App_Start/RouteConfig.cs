using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CyberPizza.LojaVirtual.Web.Models;

namespace CyberPizza.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Rota Padrão
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            // Rota : Categoria + Paginação
            routes.MapRoute(
                null,
                "{controller}/{action}/Categoria{categoria}Pagina{pagina}",
                 new
                 {
                     controller = "Vitrine",
                     action = "ListaProdutos"
                 },
                new
                {
                    pagina = @"\d+"

                }
                );

            // Rota : Paginação

            routes.MapRoute(null,
               "{controller}/{action}/Pagina{pagina}",
               new
               {
                   Controller = "Vitrine",
                   Action = "ListaProdutos",
                   categoria = (string)null
               },
                   new { pagina = @"\d+" }
               );

            //Rota : Categoria
            routes.MapRoute(
                null,
                "{controller}/{action}/Categoria{categoria}",
                new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    pagina = 1
                });
        }
    }
}
