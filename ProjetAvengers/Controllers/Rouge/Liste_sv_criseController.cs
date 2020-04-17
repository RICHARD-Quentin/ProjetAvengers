using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;

namespace ProjetAvengers.Controllers.Rouge
{
    [Route("api/[controller]")]
    [ApiController]
    public class Liste_sv_criseController : ControllerBase
    {
        private readonly AvengersContext _context;

        public Liste_sv_criseController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Liste_sv_crise
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Liste_sv_crise>>> GetListe_sv_crise()
        {
            return await _context.Liste_sv_crise.ToListAsync();
        }

        // GET: api/Liste_sv_crise/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Liste_sv_crise>> GetListe_sv_crise(int id)
        {
            var liste_sv_crise = await _context.Liste_sv_crise.FindAsync(id);

            if (liste_sv_crise == null)
            {
                return NotFound();
            }

            return liste_sv_crise;
        }

        // PUT: api/Liste_sv_crise/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListe_sv_crise(int id, Liste_sv_crise liste_sv_crise)
        {
            if (id != liste_sv_crise.Id)
            {
                return BadRequest();
            }

            _context.Entry(liste_sv_crise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Liste_sv_criseExists(id))
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

        // POST: api/Liste_sv_crise
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Liste_sv_crise>> PostListe_sv_crise(Liste_sv_crise liste_sv_crise)
        {
            _context.Liste_sv_crise.Add(liste_sv_crise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListe_sv_crise", new { id = liste_sv_crise.Id }, liste_sv_crise);
        }

        // DELETE: api/Liste_sv_crise/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Liste_sv_crise>> DeleteListe_sv_crise(int id)
        {
            var liste_sv_crise = await _context.Liste_sv_crise.FindAsync(id);
            if (liste_sv_crise == null)
            {
                return NotFound();
            }

            _context.Liste_sv_crise.Remove(liste_sv_crise);
            await _context.SaveChangesAsync();

            return liste_sv_crise;
        }

        private bool Liste_sv_criseExists(int id)
        {
            return _context.Liste_sv_crise.Any(e => e.Id == id);
        }
    }
}
