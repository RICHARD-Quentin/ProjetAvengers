using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;


namespace ProjetAvengers.Controllers.Orange
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordonneesController : ControllerBase
    {
        private readonly AvengersContext _context;

        public CoordonneesController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Coordonnees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coordonnee>>> GetCoordonnees()
        {
            return await _context.Coordonnee.ToListAsync();
        }

        // GET: api/Coordonnees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coordonnee>> GetCoordonnee(int id)
        {
            var coordonnee = await _context.Coordonnee.FindAsync(id);

            if (coordonnee == null)
            {
                return NotFound();
            }

            return coordonnee;
        }

        // PUT: api/Coordonnees/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoordonnee(int id, Coordonnee coordonnee)
        {
            if (id != coordonnee.Id)
            {
                return BadRequest();
            }

            _context.Entry(coordonnee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoordonneeExists(id))
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

        // POST: api/Coordonnees
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Coordonnee>> PostCoordonnee(Coordonnee coordonnee)
        {
            _context.Coordonnee.Add(coordonnee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCoordonnee", new { id = coordonnee.Id }, coordonnee);
        }

        // DELETE: api/Coordonnees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Coordonnee>> DeleteCoordonnee(int id)
        {
            var coordonnee = await _context.Coordonnee.FindAsync(id);
            if (coordonnee == null)
            {
                return NotFound();
            }

            _context.Coordonnee.Remove(coordonnee);
            await _context.SaveChangesAsync();

            return coordonnee;
        }

        private bool CoordonneeExists(int id)
        {
            return _context.Coordonnee.Any(e => e.Id == id);
        }
    }
}
