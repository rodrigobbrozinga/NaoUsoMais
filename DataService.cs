using Microsoft.EntityFrameworkCore;
using NaoUsoMais.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace NaoUsoMais
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();

            var json = File.ReadAllText("produtos.json");
            var produtos = JsonConvert.DeserializeObject<List<ListaProduto>>(json);

            foreach (var produto in produtos)
            {
                contexto.Set<Produto>().Add(new Produto(produto.Id, produto.Nome, produto.Descricao, produto.Preco));
                contexto.SaveChanges();
            }
        }
    }

    class ListaProduto
    {
        public string Id { get; set; }
		public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
