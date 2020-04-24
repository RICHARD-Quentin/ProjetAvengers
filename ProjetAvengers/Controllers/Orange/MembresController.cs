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
    public class MembresController : ControllerBase
    {
        private readonly AvengersContext _context;

        public MembresController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Membres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Membre>>> GetMembre()
        {
            return await _context.Membre.Include(c => c.Civils).ToListAsync();
        }

        // GET: api/Membres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Membre>> GetMembre(int id)
        {
            var membre = await _context.Membre.FindAsync(id);

            if (membre == null)
            {
                return NotFound();
            }

            return membre;
        }

        // PUT: api/Membres/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembre(int id, Membre membre)
        {
            if (id != membre.Id)
            {
                return BadRequest();
            }

            _context.Entry(membre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembreExists(id))
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

        // POST: api/Membres
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Membre>> PostMembre(Membre membre)
        {
            _context.Membre.Add(membre);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMembre", new { id = membre.Id }, membre);
        }

        // DELETE: api/Membres/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Membre>> DeleteMembre(int id)
        {
            var membre = await _context.Membre.FindAsync(id);
            if (membre == null)
            {
                return NotFound();
            }

            _context.Membre.Remove(membre);
            await _context.SaveChangesAsync();

            return membre;
        }

        private bool MembreExists(int id)
        {
            return _context.Membre.Any(e => e.Id == id);
        }
    }
}
