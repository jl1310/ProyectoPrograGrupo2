using ApiDepartamentos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using ApiDepartamentos.Context;

namespace ApiMunicipios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MunicipiosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MunicipiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Municipios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Municipios>>> GetMunicipios()
        {
            return await _context.Municipios.ToListAsync();

        }

        // GET: api/Municipios/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipios>> GetMunicipiosPorId(int id)
        {
            var resultado = await _context.Municipios.FindAsync(id);

            if (resultado == null)
            {
                return NotFound();
            }

            return resultado;
        }

        // PUT: api/Municipios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMunicipios(int id, Municipios Municipios)
        {
            if (id != Municipios.IdMunicipio)
            {
                return BadRequest();
            }

            _context.Entry(Municipios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Municipios
        [HttpPost]
        public async Task<ActionResult<Municipios>> PostMunicipios(Municipios destino)
        {
            _context.Municipios.Add(destino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMunicipios", new { id = destino.IdMunicipio }, destino);
        }

        // DELETE: api/Municipios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMunicipios(int id)
        {
            var destino = await _context.Municipios.FindAsync(id);
            if (destino == null)
            {
                return NotFound();
            }

            _context.Municipios.Remove(destino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinoExists(int id)
        {
            return _context.Municipios.Any(e => e.IdMunicipio == id);
        }
    }
}
