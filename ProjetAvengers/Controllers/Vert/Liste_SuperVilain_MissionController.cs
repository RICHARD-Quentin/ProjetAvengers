using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Data;
using ProjetAvengers.Models.Vert;

namespace ProjetAvengers.Controllers.Vert
{
    [Route("api/[controller]")]
    [ApiController]
    public class Liste_SuperVilain_MissionController : ControllerBase
    {
        private readonly VertContext _context;

        public Liste_SuperVilain_MissionController(VertContext context)
        {
            _context = context;
        }

        // GET: api/Liste_SuperVilain_Mission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Liste_SuperVilain_Mission>>> GetListe_SuperVilain_Mission()
        {
            return await _context.Liste_SuperVilain_Mission.ToListAsync();
        }

        // GET: api/Liste_SuperVilain_Mission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Liste_SuperVilain_Mission>> GetListe_SuperVilain_Mission(int id)
        {
            var liste_SuperVilain_Mission = await _context.Liste_SuperVilain_Mission.FindAsync(id);

            if (liste_SuperVilain_Mission == null)
            {
                return NotFound();
            }

            return liste_SuperVilain_Mission;
        }

        // PUT: api/Liste_SuperVilain_Mission/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListe_SuperVilain_Mission(int id, Liste_SuperVilain_Mission liste_SuperVilain_Mission)
        {
            if (id != liste_SuperVilain_Mission.Id)
            {
                return BadRequest();
            }

            _context.Entry(liste_SuperVilain_Mission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Liste_SuperVilain_MissionExists(id))
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

        // POST: api/Liste_SuperVilain_Mission
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Liste_SuperVilain_Mission>> PostListe_SuperVilain_Mission(Liste_SuperVilain_Mission liste_SuperVilain_Mission)
        {
            _context.Liste_SuperVilain_Mission.Add(liste_SuperVilain_Mission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListe_SuperVilain_Mission", new { id = liste_SuperVilain_Mission.Id }, liste_SuperVilain_Mission);
        }

        // DELETE: api/Liste_SuperVilain_Mission/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Liste_SuperVilain_Mission>> DeleteListe_SuperVilain_Mission(int id)
        {
            var liste_SuperVilain_Mission = await _context.Liste_SuperVilain_Mission.FindAsync(id);
            if (liste_SuperVilain_Mission == null)
            {
                return NotFound();
            }

            _context.Liste_SuperVilain_Mission.Remove(liste_SuperVilain_Mission);
            await _context.SaveChangesAsync();

            return liste_SuperVilain_Mission;
        }

        private bool Liste_SuperVilain_MissionExists(int id)
        {
            return _context.Liste_SuperVilain_Mission.Any(e => e.Id == id);
        }
    }
}
