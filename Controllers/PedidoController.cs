using Microsoft.AspNetCore.Mvc;
using NaoUsoMais.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaoUsoMais.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IActionResult Catalogo()
        {            
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
