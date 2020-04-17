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
    public class Liste_sh_criseController : ControllerBase
    {
        private readonly AvengersContext _context;

        public Liste_sh_criseController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Liste_sh_crise
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Liste_sh_crise>>> GetListe_sh_crise()
        {
            return await _context.Liste_sh_crise.ToListAsync();
        }

        // GET: api/Liste_sh_crise/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Liste_sh_crise>> GetListe_sh_crise(int id)
        {
            var liste_sh_crise = await _context.Liste_sh_crise.FindAsync(id);

            if (liste_sh_crise == null)
            {
                return NotFound();
            }

            return liste_sh_crise;
        }

        // PUT: api/Liste_sh_crise/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListe_sh_crise(int id, Liste_sh_crise liste_sh_crise)
        {
            if (id != liste_sh_crise.Id)
            {
                return BadRequest();
            }

            _context.Entry(liste_sh_crise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Liste_sh_criseExists(id))
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

        // POST: api/Liste_sh_crise
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Liste_sh_crise>> PostListe_sh_crise(Liste_sh_crise liste_sh_crise)
        {
            _context.Liste_sh_crise.Add(liste_sh_crise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListe_sh_crise", new { id = liste_sh_crise.Id }, liste_sh_crise);
        }

        // DELETE: api/Liste_sh_crise/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Liste_sh_crise>> DeleteListe_sh_crise(int id)
        {
            var liste_sh_crise = await _context.Liste_sh_crise.FindAsync(id);
            if (liste_sh_crise == null)
            {
                return NotFound();
            }

            _context.Liste_sh_crise.Remove(liste_sh_crise);
            await _context.SaveChangesAsync();

            return liste_sh_crise;
        }

        private bool Liste_sh_criseExists(int id)
        {
            return _context.Liste_sh_crise.Any(e => e.Id == id);
        }
    }
}
