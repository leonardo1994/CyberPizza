using System.ComponentModel.DataAnnotations;

namespace CyberPizza.LojaVirtual.Dominio.Entidades
{
    public class Logradouro
    {
        [Key]
        public int Ukey { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public char Estado { get; set; }
    }
}
