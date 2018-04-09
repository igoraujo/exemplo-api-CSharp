using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API2.Model;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ProdutoContext _context;
        public ValuesController(ProdutoContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _context.produto.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _context.produto.FirstOrDefault(x => x.id == id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Produto value)
        {
            _context.produto.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

