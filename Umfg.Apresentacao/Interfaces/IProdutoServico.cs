using Umfg.Apresentacao.Entities;

namespace Umfg.Apresentacao.Interfaces
{
    public interface IProdutoServico
    {
        IEnumerable<Produto> ObterTodos();
        Produto ObterPorCodigoBarra(string codigoBarra);
    }
}