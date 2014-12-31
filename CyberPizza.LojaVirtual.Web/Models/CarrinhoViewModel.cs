using CyberPizza.LojaVirtual.Dominio.Entidades;

namespace CyberPizza.LojaVirtual.Web.Models
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }
        public string ReturnUrl { get; set; }

    }
}