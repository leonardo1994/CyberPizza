using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CyberPizza.LojaVirtual.Dominio.Entidades;

namespace CyberPizza.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }
    }
}