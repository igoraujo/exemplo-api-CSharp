using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class GrupoController : Controller
    {
        private readonly Context _context;
        public GrupoController(Context context)
        {
            _context = context;
        }

        // GET api/grupo
        [HttpGet]
        public IEnumerable<Grupo> Get()
        {
            return _context.Grupo.ToList();
        }

        // GET api/grupo/5
        [HttpGet("{id}")]
        public Grupo Get(int id)
        {
            return _context.Grupo.FirstOrDefault(x => x.Id == id);
        }

        // POST api/grupo
        [HttpPost]
        public IActionResult Post([FromBody] Grupo grupo)
        {
            _context.Grupo.Add(grupo);
            _context.SaveChanges();
            return Ok(grupo);
        }

        // PUT api/grupo/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Grupo grupo)
        {
            if (grupo == null || grupo.Id != id)
            {
                //Requisicao invalida
                return NotFound(grupo);
            }

            if (grupo == null)
            {
                //Bad Request
                return BadRequest(grupo);
            }

            _context.Grupo.Update(grupo);
            _context.SaveChanges();
            return Ok(grupo);


        }

        // DELETE api/grupo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Grupo grupo = _context.Grupo.FirstOrDefault(t => t.Id == id);

            if (grupo == null)
            {
                return NotFound(grupo);
            }

            _context.Grupo.Remove(grupo);
            _context.SaveChanges();
            return Ok(grupo);
        }
    }
}
