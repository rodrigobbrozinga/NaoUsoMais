using NaoUsoMais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaoUsoMais.Repositories
{
    public interface IPedidoRepository
    {

    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
