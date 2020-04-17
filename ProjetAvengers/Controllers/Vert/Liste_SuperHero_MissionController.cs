using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;
using ProjetAvengers.Models.Vert;

namespace ProjetAvengers.Controllers.Vert
{
    [Route("api/[controller]")]
    [ApiController]
    public class Liste_SuperHero_MissionController : ControllerBase
    {
        private readonly AvengersContext _context;

        public Liste_SuperHero_MissionController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Liste_SuperHero_Mission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Liste_SuperHero_Mission>>> GetListe_SuperHero_Mission()
        {
            return await _context.Liste_SuperHero_Mission.ToListAsync();
        }

        // GET: api/Liste_SuperHero_Mission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Liste_SuperHero_Mission>> GetListe_SuperHero_Mission(int id)
        {
            var liste_SuperHero_Mission = await _context.Liste_SuperHero_Mission.FindAsync(id);

            if (liste_SuperHero_Mission == null)
            {
                return NotFound();
            }

            return liste_SuperHero_Mission;
        }

        // PUT: api/Liste_SuperHero_Mission/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListe_SuperHero_Mission(int id, Liste_SuperHero_Mission liste_SuperHero_Mission)
        {
            if (id != liste_SuperHero_Mission.Id)
            {
                return BadRequest();
            }

            _context.Entry(liste_SuperHero_Mission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Liste_SuperHero_MissionExists(id))
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

        // POST: api/Liste_SuperHero_Mission
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Liste_SuperHero_Mission>> PostListe_SuperHero_Mission(Liste_SuperHero_Mission liste_SuperHero_Mission)
        {
            _context.Liste_SuperHero_Mission.Add(liste_SuperHero_Mission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListe_SuperHero_Mission", new { id = liste_SuperHero_Mission.Id }, liste_SuperHero_Mission);
        }

        // DELETE: api/Liste_SuperHero_Mission/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Liste_SuperHero_Mission>> DeleteListe_SuperHero_Mission(int id)
        {
            var liste_SuperHero_Mission = await _context.Liste_SuperHero_Mission.FindAsync(id);
            if (liste_SuperHero_Mission == null)
            {
                return NotFound();
            }

            _context.Liste_SuperHero_Mission.Remove(liste_SuperHero_Mission);
            await _context.SaveChangesAsync();

            return liste_SuperHero_Mission;
        }

        private bool Liste_SuperHero_MissionExists(int id)
        {
            return _context.Liste_SuperHero_Mission.Any(e => e.Id == id);
        }
    }
}
