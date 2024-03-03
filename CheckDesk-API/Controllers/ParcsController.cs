using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CheckDesk_API.Database;
using CheckDesk_API.Models;

namespace CheckDesk_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParcsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ParcsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Parcs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parc>>> GetParc()
        {
            return await _context.Parc.ToListAsync();
        }

        // GET: api/Parcs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parc>> GetParc(int id)
        {
            var parc = await _context.Parc.FindAsync(id);

            if (parc == null)
            {
                return NotFound();
            }

            return parc;
        }

        // PUT: api/Parcs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParc(int id, Parc parc)
        {
            if (id != parc.Id)
            {
                return BadRequest();
            }

            _context.Entry(parc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParcExists(id))
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

        // POST: api/Parcs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Parc>> PostParc(Parc parc)
        {
            _context.Parc.Add(parc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParc", new { id = parc.Id }, parc);
        }

        // DELETE: api/Parcs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParc(int id)
        {
            var parc = await _context.Parc.FindAsync(id);
            if (parc == null)
            {
                return NotFound();
            }

            _context.Parc.Remove(parc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParcExists(int id)
        {
            return _context.Parc.Any(e => e.Id == id);
        }
    }
}
