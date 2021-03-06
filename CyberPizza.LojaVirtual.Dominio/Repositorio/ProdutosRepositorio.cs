﻿using System.Collections.Generic;
using CyberPizza.LojaVirtual.Dominio.Entidades;

namespace CyberPizza.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
