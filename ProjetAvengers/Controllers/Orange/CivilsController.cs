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
        public async Task<ActionResult<IEnumerable<CivilsDTO>>> GetCivils()
        {
            return await _context.Civils
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        // GET: api/Civils/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CivilsDTO>> GetCivils(long id)
        {
            var Civils = await _context.Civils.FindAsync(id);

            if (Civils == null)
            {
                return NotFound();
            }

            return ItemToDTO(Civils);
        }

        // PUT: api/Civils/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCivils(long id, CivilsDTO CivilsDTO)
        {
            if (id != CivilsDTO.Id)
            {
                return BadRequest();
            }

            var Civils = await _context.Civils.FindAsync(id);
            if (Civils == null)
            {
                return NotFound();
            }

            Civils.Civilite = CivilsDTO.Civilite;
            Civils.Nom = CivilsDTO.Nom;
            Civils.Prenom = CivilsDTO.Prenom;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CivilsExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Civils
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CivilsDTO>> CreateCivils(CivilsDTO CivilsDTO)
        {
            var Civils = new Civils
            {
            Civilite = CivilsDTO.Civilite,
            Nom = CivilsDTO.Nom,
            Prenom = CivilsDTO.Prenom
        
        };

            _context.Civils.Add(Civils);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCivils),
                new { id = Civils.Id },
                ItemToDTO(Civils));
        }

        // DELETE: api/Civils/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCivils(long id)
        {
            var Civils = await _context.Civils.FindAsync(id);

            if (Civils == null)
            {
                return NotFound();
            }

            _context.Civils.Remove(Civils);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CivilsExists(long id) =>
             _context.Civils.Any(e => e.Id == id);

        private static CivilsDTO ItemToDTO(Civils Civils) =>
            new CivilsDTO
            {
                Id = Civils.Id,
                Civilite=Civils.Civilite,
                Nom = Civils.Nom,
                Prenom = Civils.Prenom
            };
    }
}
