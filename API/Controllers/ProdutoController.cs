using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API.Models;
/// <summary>
/// Esta Controller faz todo o gerenciamento do recebimento das requisicoes HTTP, e responde de acordo com a URL passada.
/// </summary>
namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly Context _context;
        public ProdutoController(Context context)
        {
            _context = context;
        }

        // GET api/produto
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _context.Produto.ToList();
        }

        // GET api/produto/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _context.Produto.FirstOrDefault(x => x.Id == id);
        }

        // POST api/produto
        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
            //retorna status OK, Metodo herdado da classe Controller
            //ele implementa o "OkObjectResult" ou o "OkResult"

            return Ok(produto);

        }

        // PUT api/produto/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Produto produto)
        {
            if (produto == null || produto.Id != id)
            {
                //Requisicao invalida
                return NotFound(produto);
            }
            
            if (produto == null)
            {
                //Bad Request
                return BadRequest(produto);
            }
            
            _context.Produto.Update(produto);
            _context.SaveChanges();
            return Ok(produto);

        }

        // DELETE api/produto/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Produto produto = _context.Produto.FirstOrDefault(t => t.Id == id);

            if (produto == null)
            {
                return NotFound(produto);
            }

            _context.Produto.Remove(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}
