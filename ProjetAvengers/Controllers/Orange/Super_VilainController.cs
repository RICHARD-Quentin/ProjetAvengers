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
    public class Super_VilainController : ControllerBase
    {
        private readonly AvengersContext _context;

        public Super_VilainController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Super_Vilain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Super_Vilain>>> GetSuper_Vilain()
        {
            return await _context.Super_Vilain.ToListAsync();
        }

        // GET: api/Super_Vilain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Super_Vilain>> GetSuper_Vilain(int id)
        {
            var super_Vilain = await _context.Super_Vilain.FindAsync(id);

            if (super_Vilain == null)
            {
                return NotFound();
            }

            return super_Vilain;
        }

        // PUT: api/Super_Vilain/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuper_Vilain(int id, Super_Vilain super_Vilain)
        {
            if (id != super_Vilain.Id)
            {
                return BadRequest();
            }

            _context.Entry(super_Vilain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Super_VilainExists(id))
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

        // POST: api/Super_Vilain
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Super_Vilain>> PostSuper_Vilain(Super_Vilain super_Vilain)
        {
            _context.Super_Vilain.Add(super_Vilain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuper_Vilain", new { id = super_Vilain.Id }, super_Vilain);
        }

        // DELETE: api/Super_Vilain/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Super_Vilain>> DeleteSuper_Vilain(int id)
        {
            var super_Vilain = await _context.Super_Vilain.FindAsync(id);
            if (super_Vilain == null)
            {
                return NotFound();
            }

            _context.Super_Vilain.Remove(super_Vilain);
            await _context.SaveChangesAsync();

            return super_Vilain;
        }

        private bool Super_VilainExists(int id)
        {
            return _context.Super_Vilain.Any(e => e.Id == id);
        }
    }
}
