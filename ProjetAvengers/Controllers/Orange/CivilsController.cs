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
    public class CivilsController : ControllerBase
    {
        private readonly AvengersContext _context;

        public CivilsController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Civils
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Civils>>> GetCivils()
        {
            return await _context.Civils.Include(C => C.Coordonnees).ToListAsync();
        }

        // GET: api/Civils/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Civils>> GetCivils(int id)
        {
            var civils = await _context.Civils.FindAsync(id);

            if (civils == null)
            {
                return NotFound();
            }

            return civils;
        }

        // PUT: api/Civils/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCivils(int id, Civils civils)
        {
            if (id != civils.Id)
            {
                return BadRequest();
            }

            _context.Entry(civils).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CivilsExists(id))
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

        // POST: api/Civils
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Civils>> PostCivils(Civils civils)
        {
            _context.Civils.Add(civils);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCivils", new { id = civils.Id }, civils);
        }

        // DELETE: api/Civils/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Civils>> DeleteCivils(int id)
        {
            var civils = await _context.Civils.FindAsync(id);
            if (civils == null)
            {
                return NotFound();
            }

            _context.Civils.Remove(civils);
            await _context.SaveChangesAsync();

            return civils;
        }

        private bool CivilsExists(int id)
        {
            return _context.Civils.Any(e => e.Id == id);
        }
    }
}
