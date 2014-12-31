using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberPizza.LojaVirtual.Dominio.Entidades;

namespace CyberPizza.LojaVirtual.Dominio.Repositorio
{
    public class LogradouroRepoitorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public DbSet<Logradouro> Logradouros
        {
            get { return _context.Logradouros; }
        }
    }
}
