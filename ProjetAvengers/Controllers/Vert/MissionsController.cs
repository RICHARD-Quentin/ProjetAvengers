using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProjetAvengers.Models;
using ProjetAvengers.Models.Vert;

namespace ProjetAvengers.Controllers.Vert
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionsController : ControllerBase
    {
        private readonly AvengersContext _context;

        public MissionsController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/Missions
        [HttpGet]
        public String Get()
        {
            return JsonConvert.SerializeObject(_context.Mission.Include(i => i.Incidents).ToList(), Formatting.Indented,
            new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
        [HttpGet("EnCours")]
        public String EnCours()
        {
            return JsonConvert.SerializeObject(_context.Mission.Include(i => i.Incidents).Where(m => m.Date_fin == null && m.Date_debut != null).ToList(), Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }

        [HttpGet("EnAttente")]
        public String EnAttente()
        {
            return JsonConvert.SerializeObject(_context.Mission.Include(i => i.Incidents).Where(m => m.Date_debut == null).ToList(), Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }

        [HttpGet("Terminee")]
        public String Terminee()
        {
            return JsonConvert.SerializeObject(_context.Mission.Include(i => i.Incidents).Include(r => r.Rapport_Mission).Where(m => m.Date_fin != null).ToList(), Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }
        // GET: api/Missions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission(int id)
        {
            var mission = await _context.Mission.FindAsync(id);

            if (mission == null)
            {
                return NotFound();
            }

            return mission;
        }

        // PUT: api/Missions/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMission(int id, Mission mission)
        {
            if (id != mission.Id)
            {
                return BadRequest();
            }

            _context.Entry(mission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MissionExists(id))
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

        // POST: api/Missions
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Mission>> PostMission(Mission mission)
        {
            _context.Mission.Add(mission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMission", new { id = mission.Id }, mission);
        }

        // DELETE: api/Missions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mission>> DeleteMission(int id)
        {
            var mission = await _context.Mission.FindAsync(id);
            if (mission == null)
            {
                return NotFound();
            }

            _context.Mission.Remove(mission);
            await _context.SaveChangesAsync();

            return mission;
        }

        private bool MissionExists(int id)
        {
            return _context.Mission.Any(e => e.Id == id);
        }
    }
}
