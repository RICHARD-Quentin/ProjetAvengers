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
    public class SatisfactionsController : ControllerBase
    {
        private readonly AvengersContext _context;

        public SatisfactionsController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Satisfactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Satisfaction>>> GetSatisfaction()
        {
            return await _context.Satisfaction.ToListAsync();
        }

        // GET: api/Satisfactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Satisfaction>> GetSatisfaction(int id)
        {
            var satisfaction = await _context.Satisfaction.FindAsync(id);

            if (satisfaction == null)
            {
                return NotFound();
            }

            return satisfaction;
        }

        // PUT: api/Satisfactions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSatisfaction(int id, Satisfaction satisfaction)
        {
            if (id != satisfaction.Id)
            {
                return BadRequest();
            }

            _context.Entry(satisfaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SatisfactionExists(id))
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

        // POST: api/Satisfactions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Satisfaction>> PostSatisfaction(Satisfaction satisfaction)
        {
            _context.Satisfaction.Add(satisfaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSatisfaction", new { id = satisfaction.Id }, satisfaction);
        }

        // DELETE: api/Satisfactions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Satisfaction>> DeleteSatisfaction(int id)
        {
            var satisfaction = await _context.Satisfaction.FindAsync(id);
            if (satisfaction == null)
            {
                return NotFound();
            }

            _context.Satisfaction.Remove(satisfaction);
            await _context.SaveChangesAsync();

            return satisfaction;
        }

        private bool SatisfactionExists(int id)
        {
            return _context.Satisfaction.Any(e => e.Id == id);
        }
    }
}
