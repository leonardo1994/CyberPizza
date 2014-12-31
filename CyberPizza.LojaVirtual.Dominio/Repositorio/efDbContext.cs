using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CyberPizza.LojaVirtual.Dominio.Entidades;

namespace CyberPizza.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Logradouro> Logradouros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Logradouro>().ToTable("Logradouros");
        }
    }
}
