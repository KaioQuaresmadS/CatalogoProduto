using Microsoft.AspNetCore.Mvc;
using CatalogoProdutos.Models;
using CatalogoProdutos.Context;
using Microsoft.EntityFrameworkCore;


namespace CatalogoProdutos.Controllers
{

    [Route("[Controller] [id]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AddDbContext _context;
        public ProdutosController(AddDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produtos>> Get()
        {
            try
            {
                var produtos = _context.Produto.AsNoTracking().ToList();

                if (produtos == null)
                {
                    return NotFound();
                }

                return Ok(produtos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um problema na sua solicitação");
            }
        }

        [HttpGet(" {id:int} ")]
        public ActionResult<Produtos> Get(int id)
        {
            try
            {
                var produtos = _context.Produto.FirstOrDefault(p => p.ProdutoId == id);
                {
                    if (produtos == null)
                    {
                        return NotFound();
                    }

                    return produtos;

                }
            }
            catch (Exception)
            {
                return StatusCode(500, "ID não encontrado");
            }
        }

    }
}
