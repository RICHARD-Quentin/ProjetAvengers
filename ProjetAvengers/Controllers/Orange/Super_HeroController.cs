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
    public class Super_HeroController : ControllerBase
    {
        private readonly AvengersContext _context;

        public Super_HeroController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Super_Hero
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Super_Hero>>> GetSuper_Hero()
        {
            return await _context.Super_Hero.ToListAsync();
        }

        // GET: api/Super_Hero/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Super_Hero>> GetSuper_Hero(int id)
        {
            var super_Hero = await _context.Super_Hero.FindAsync(id);

            if (super_Hero == null)
            {
                return NotFound();
            }

            return super_Hero;
        }

        // PUT: api/Super_Hero/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuper_Hero(int id, Super_Hero super_Hero)
        {
            if (id != super_Hero.Id)
            {
                return BadRequest();
            }

            _context.Entry(super_Hero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Super_HeroExists(id))
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

        // POST: api/Super_Hero
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Super_Hero>> PostSuper_Hero(Super_Hero super_Hero)
        {
            _context.Super_Hero.Add(super_Hero);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuper_Hero", new { id = super_Hero.Id }, super_Hero);
        }

        // DELETE: api/Super_Hero/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Super_Hero>> DeleteSuper_Hero(int id)
        {
            var super_Hero = await _context.Super_Hero.FindAsync(id);
            if (super_Hero == null)
            {
                return NotFound();
            }

            _context.Super_Hero.Remove(super_Hero);
            await _context.SaveChangesAsync();

            return super_Hero;
        }

        private bool Super_HeroExists(int id)
        {
            return _context.Super_Hero.Any(e => e.Id == id);
        }
    }
}
