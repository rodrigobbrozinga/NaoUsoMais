using NaoUsoMais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaoUsoMais.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void SaveProdutos(List<ListaProduto> produtos)
        {
            foreach (var produto in produtos)
            {
                contexto.Set<Produto>().Add(new Produto(produto.Id, produto.Nome, produto.Descricao, produto.Preco));
                contexto.SaveChanges();
            }
        }
    }
    public class ListaProduto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }

}
