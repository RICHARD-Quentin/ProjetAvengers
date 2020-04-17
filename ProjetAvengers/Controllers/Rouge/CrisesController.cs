using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;

namespace ProjetAvengers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrisesController : ControllerBase
    {
        private readonly AvengersContext _context;

        public CrisesController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Crises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crise>>> GetCrise()
        {
            return await _context.Crise.ToListAsync();
        }

        // GET: api/Crises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Crise>> GetCrise(int id)
        {
            var crise = await _context.Crise.FindAsync(id);

            if (crise == null)
            {
                return NotFound();
            }

            return crise;
        }

        // PUT: api/Crises/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrise(int id, Crise crise)
        {
            if (id != crise.Id)
            {
                return BadRequest();
            }

            _context.Entry(crise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriseExists(id))
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

        // POST: api/Crises
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Crise>> PostCrise(Crise crise)
        {
            _context.Crise.Add(crise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCrise", new { id = crise.Id }, crise);
        }

        // DELETE: api/Crises/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Crise>> DeleteCrise(int id)
        {
            var crise = await _context.Crise.FindAsync(id);
            if (crise == null)
            {
                return NotFound();
            }

            _context.Crise.Remove(crise);
            await _context.SaveChangesAsync();

            return crise;
        }

        private bool CriseExists(int id)
        {
            return _context.Crise.Any(e => e.Id == id);
        }
    }
}
