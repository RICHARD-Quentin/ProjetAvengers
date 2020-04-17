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
    public class Rapport_MissionController : ControllerBase
    {
        private readonly AvengersContext _context;

        public Rapport_MissionController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Rapport_Mission
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rapport_Mission>>> GetRapport_Mission()
        {
            return await _context.Rapport_Mission.ToListAsync();
        }

        // GET: api/Rapport_Mission/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rapport_Mission>> GetRapport_Mission(int id)
        {
            var rapport_Mission = await _context.Rapport_Mission.FindAsync(id);

            if (rapport_Mission == null)
            {
                return NotFound();
            }

            return rapport_Mission;
        }

        // PUT: api/Rapport_Mission/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRapport_Mission(int id, Rapport_Mission rapport_Mission)
        {
            if (id != rapport_Mission.Id)
            {
                return BadRequest();
            }

            _context.Entry(rapport_Mission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Rapport_MissionExists(id))
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

        // POST: api/Rapport_Mission
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Rapport_Mission>> PostRapport_Mission(Rapport_Mission rapport_Mission)
        {
            _context.Rapport_Mission.Add(rapport_Mission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRapport_Mission", new { id = rapport_Mission.Id }, rapport_Mission);
        }

        // DELETE: api/Rapport_Mission/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rapport_Mission>> DeleteRapport_Mission(int id)
        {
            var rapport_Mission = await _context.Rapport_Mission.FindAsync(id);
            if (rapport_Mission == null)
            {
                return NotFound();
            }

            _context.Rapport_Mission.Remove(rapport_Mission);
            await _context.SaveChangesAsync();

            return rapport_Mission;
        }

        private bool Rapport_MissionExists(int id)
        {
            return _context.Rapport_Mission.Any(e => e.Id == id);
        }
    }
}
