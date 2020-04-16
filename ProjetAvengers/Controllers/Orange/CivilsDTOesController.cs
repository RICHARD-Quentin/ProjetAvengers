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
    public class CivilsDTOesController : ControllerBase
    {
        private readonly AvengersContext _context;

        public CivilsDTOesController(AvengersContext context)
        {
            _context = context;
        }

        // GET: api/CivilsDTOes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CivilsDTO>>> GetCivilsDTO()
        {
            return await _context.CivilsDTO.ToListAsync();
        }

        // GET: api/CivilsDTOes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CivilsDTO>> GetCivilsDTO(int id)
        {
            var civilsDTO = await _context.CivilsDTO.FindAsync(id);

            if (civilsDTO == null)
            {
                return NotFound();
            }

            return civilsDTO;
        }

        // PUT: api/CivilsDTOes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCivilsDTO(int id, CivilsDTO civilsDTO)
        {
            if (id != civilsDTO.Id)
            {
                return BadRequest();
            }

            _context.Entry(civilsDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CivilsDTOExists(id))
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

        // POST: api/CivilsDTOes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CivilsDTO>> PostCivilsDTO(CivilsDTO civilsDTO)
        {
            _context.CivilsDTO.Add(civilsDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCivilsDTO", new { id = civilsDTO.Id }, civilsDTO);
        }

        // DELETE: api/CivilsDTOes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CivilsDTO>> DeleteCivilsDTO(int id)
        {
            var civilsDTO = await _context.CivilsDTO.FindAsync(id);
            if (civilsDTO == null)
            {
                return NotFound();
            }

            _context.CivilsDTO.Remove(civilsDTO);
            await _context.SaveChangesAsync();

            return civilsDTO;
        }

        private bool CivilsDTOExists(int id)
        {
            return _context.CivilsDTO.Any(e => e.Id == id);
        }
    }
}
