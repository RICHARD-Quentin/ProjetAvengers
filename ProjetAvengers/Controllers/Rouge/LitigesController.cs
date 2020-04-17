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
    public class LitigesController : ControllerBase
    {
        private readonly AvengersContext _context;

        public LitigesController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Litiges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Litige>>> GetLitige()
        {
            return await _context.Litige.ToListAsync();
        }

        // GET: api/Litiges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Litige>> GetLitige(int id)
        {
            var litige = await _context.Litige.FindAsync(id);

            if (litige == null)
            {
                return NotFound();
            }

            return litige;
        }

        // PUT: api/Litiges/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLitige(int id, Litige litige)
        {
            if (id != litige.Id)
            {
                return BadRequest();
            }

            _context.Entry(litige).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LitigeExists(id))
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

        // POST: api/Litiges
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Litige>> PostLitige(Litige litige)
        {
            _context.Litige.Add(litige);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLitige", new { id = litige.Id }, litige);
        }

        // DELETE: api/Litiges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Litige>> DeleteLitige(int id)
        {
            var litige = await _context.Litige.FindAsync(id);
            if (litige == null)
            {
                return NotFound();
            }

            _context.Litige.Remove(litige);
            await _context.SaveChangesAsync();

            return litige;
        }

        private bool LitigeExists(int id)
        {
            return _context.Litige.Any(e => e.Id == id);
        }
    }
}
