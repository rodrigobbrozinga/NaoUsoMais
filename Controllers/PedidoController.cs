using Microsoft.AspNetCore.Mvc;
using NaoUsoMais.Models;
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
        private readonly IPedidoRepository pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Catalogo()
        {            
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }

            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido.Itens);
        }

        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
