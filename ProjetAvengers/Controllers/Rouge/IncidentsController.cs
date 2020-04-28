using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProjetAvengers.Models;

namespace ProjetAvengers.Controllers.Rouge
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        private readonly AvengersContext _context;

        public IncidentsController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Incidents
        [HttpGet]
        public String Get()
        {
            return JsonConvert.SerializeObject(_context.Incidents.Include(i => i.Identite_origine_appel).ToList(), Formatting.Indented,
            new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
        [HttpGet("Traite")]
        public String Traite()
        {
            return JsonConvert.SerializeObject(_context.Incidents.Where(m => m.estTraite == true).ToList(), Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }
        [HttpGet("NonTraite")]
        public String NonTraite()
        {
            return JsonConvert.SerializeObject(_context.Incidents.Where(m => m.estTraite == false).ToList(), Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }

        // GET: api/Incidents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Incidents>> GetIncidents(int id)
        {
            var incidents = await _context.Incidents.FindAsync(id);

            if (incidents == null)
            {
                return NotFound();
            }

            return incidents;
        }

        // PUT: api/Incidents/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncidents(int id, Incidents incidents)
        {
            if (id != incidents.Id)
            {
                return BadRequest();
            }

            _context.Entry(incidents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidentsExists(id))
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

        // POST: api/Incidents
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Incidents>> PostIncidents(Incidents incidents)
        {
            _context.Incidents.Add(incidents);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIncidents", new { id = incidents.Id }, incidents);
        }

        // DELETE: api/Incidents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Incidents>> DeleteIncidents(int id)
        {
            var incidents = await _context.Incidents.FindAsync(id);
            if (incidents == null)
            {
                return NotFound();
            }

            _context.Incidents.Remove(incidents);
            await _context.SaveChangesAsync();

            return incidents;
        }

        private bool IncidentsExists(int id)
        {
            return _context.Incidents.Any(e => e.Id == id);
        }
    }
}
