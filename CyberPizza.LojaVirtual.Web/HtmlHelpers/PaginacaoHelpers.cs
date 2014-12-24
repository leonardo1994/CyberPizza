using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CyberPizza.LojaVirtual.Web.Models;

namespace CyberPizza.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper htmlHelper, Paginacao paginacao, Func<int, string> paginaUrl)
        {
           var resultado = new StringBuilder();
            for (var i = 1; i < paginacao.TotalPagina; i++)
            {
                var tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual) tag.AddCssClass("Selected"); tag.AddCssClass("btn-primary");
                tag.AddCssClass("btn-default");
                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}