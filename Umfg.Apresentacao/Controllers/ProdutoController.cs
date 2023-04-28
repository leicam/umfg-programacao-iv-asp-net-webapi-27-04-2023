using Microsoft.AspNetCore.Mvc;
using Umfg.Apresentacao.Entities;

namespace Umfg.Apresentacao.Controllers
{
    [ApiController]
    [Route("umfg/api/v1/produto")]
    public sealed class ProdutoController : ControllerBase
    {
        private List<Produto> _lista = new List<Produto>()
        {
            new Produto()
            {
                CodigoBarra = "10000001",
                Decricao = "Coca-Cola 350ml",
                Valor = 4.99m,
            },
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_lista.AsEnumerable());
        }

        [HttpGet("{codigoBarra}")]
        public IActionResult Get(string codigoBarra)
        {
            return Ok(_lista.FirstOrDefault(x => x.CodigoBarra == codigoBarra));
        }
    }
}