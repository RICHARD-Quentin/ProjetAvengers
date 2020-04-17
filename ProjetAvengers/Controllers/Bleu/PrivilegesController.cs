using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetAvengers.Models;
using ProjetAvengers.Models.Bleu;

namespace ProjetAvengers.Controllers.Bleu
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivilegesController : ControllerBase
    {
        private readonly AvengersContext _context;

        public PrivilegesController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Privileges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Privileges>>> GetPrivileges()
        {
            return await _context.Privileges.ToListAsync();
        }

        // GET: api/Privileges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Privileges>> GetPrivileges(int id)
        {
            var privileges = await _context.Privileges.FindAsync(id);

            if (privileges == null)
            {
                return NotFound();
            }

            return privileges;
        }

        // PUT: api/Privileges/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrivileges(int id, Privileges privileges)
        {
            if (id != privileges.Id)
            {
                return BadRequest();
            }

            _context.Entry(privileges).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrivilegesExists(id))
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

        // POST: api/Privileges
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Privileges>> PostPrivileges(Privileges privileges)
        {
            _context.Privileges.Add(privileges);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPrivileges", new { id = privileges.Id }, privileges);
        }

        // DELETE: api/Privileges/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Privileges>> DeletePrivileges(int id)
        {
            var privileges = await _context.Privileges.FindAsync(id);
            if (privileges == null)
            {
                return NotFound();
            }

            _context.Privileges.Remove(privileges);
            await _context.SaveChangesAsync();

            return privileges;
        }

        private bool PrivilegesExists(int id)
        {
            return _context.Privileges.Any(e => e.Id == id);
        }
    }
}
