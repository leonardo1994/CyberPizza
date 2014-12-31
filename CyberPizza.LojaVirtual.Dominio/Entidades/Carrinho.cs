using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPizza.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itemCarrinhos = new List<ItemCarrinho>();
        
        //Adicionar
        public void AdicionarItem(Produto produto, int quantidade)
        {
            var item = _itemCarrinhos.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            if (item == null)
            {
                _itemCarrinhos.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        }

        //Remover
        public void RemoverItem(Produto produto)
        {
            _itemCarrinhos.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
        }

        //Obter Valor Total
        public Decimal ObterValorTotal()
        {
            return _itemCarrinhos.Sum(e => e.Produto.Preco*e.Quantidade);
        }

        //Limpar Carrinho
        public void LimparCarrinho()
        {
            _itemCarrinhos.Clear();
        }

        //Itens Carrinho
        public IEnumerable<ItemCarrinho> ItemCarrinhos
        {
            get { return _itemCarrinhos; }
        } 
    }

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

    }
}
