using System;
using System.Text;
using System.Web.Mvc;
using CyberPizza.LojaVirtual.Web.Models;

namespace CyberPizza.LojaVirtual.Web.HtmlHelpers
{
    public static class MenssagensPadroes
    {
        public static MvcHtmlString MessageStandard(this HtmlHelper htmlHelper, int tipo, string url = "", string textoUrl = "", string textoMenssagem = "")
        {
            var resultado = new StringBuilder();

            var tag = new TagBuilder("div");
            tag.MergeAttribute("role", "alert");
            var strong = new TagBuilder("strong") {InnerHtml = textoMenssagem};
            var taga = new TagBuilder("a");
            taga.MergeAttribute("href", url);
            taga.InnerHtml = textoUrl;
            strong.InnerHtml = strong.InnerHtml + taga; 
            tag.InnerHtml =  strong.ToString();

            switch (tipo)
            {
                case 1:
                    tag.AddCssClass("alert alert-success alert-dismissible");
                    break;
                case 2:
                    tag.AddCssClass("alert alert-info alert-dismissible");
                    break;
                case 3:
                    tag.AddCssClass("alert alert-warning alert-dismissible");
                    break;
                case 4:
                    tag.AddCssClass("alert alert-danger alert-dismissible");
                    break;
            }
            resultado.Append(tag);
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}