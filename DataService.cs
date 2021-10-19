using Microsoft.EntityFrameworkCore;
using NaoUsoMais.Models;
using NaoUsoMais.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace NaoUsoMais
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();
            List<ListaProduto> produtos = GetProdutos();

            produtoRepository.SaveProdutos(produtos);
        }        

        private static List<ListaProduto> GetProdutos()
        {
            var json = File.ReadAllText("produtos.json");
            var produtos = JsonConvert.DeserializeObject<List<ListaProduto>>(json);
            return produtos;
        }
    }    
}
