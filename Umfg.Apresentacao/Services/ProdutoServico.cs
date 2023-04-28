using Umfg.Apresentacao.Entities;
using Umfg.Apresentacao.Exceptions;
using Umfg.Apresentacao.Interfaces;

namespace Umfg.Apresentacao.Services
{
    public sealed class ProdutoServico : IProdutoServico
    {
        private readonly List<Produto> _lista = new List<Produto>()
        {
            new Produto()
            {
                CodigoBarra = "10000001",
                Decricao = "Coca-Cola 350ml",
                Valor = 4.99m,
            },
        };

        public Produto ObterPorCodigoBarra(string codigoBarra)
        {
            var produto = _lista.FirstOrDefault(x => x.CodigoBarra == codigoBarra);

            if (produto == null)
                throw new NotFoundException("Produto não encontrado");

            return produto;
        }

        public IEnumerable<Produto> ObterTodos() => _lista;
    }
}