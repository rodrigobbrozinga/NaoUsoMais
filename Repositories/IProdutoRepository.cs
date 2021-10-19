using System.Collections.Generic;

namespace NaoUsoMais.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<ListaProduto> produtos);
    }
}