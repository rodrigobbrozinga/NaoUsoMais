using NaoUsoMais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaoUsoMais.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        public void SaveProdutos(List<ListaProduto> produtos)
        {
            foreach (var produto in produtos)
            {
                if (!dbSet.Where(p => p.Codigo == produto.Codigo).Any())
                {
                    dbSet.Add(new Produto(produto.Codigo, produto.Nome, produto.Descricao, produto.Preco));
                }
            }
                contexto.SaveChanges();
        }
    }
    public class ListaProduto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }

}
