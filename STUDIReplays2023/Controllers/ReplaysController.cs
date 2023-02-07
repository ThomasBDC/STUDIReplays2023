using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using STUDIReplays2023.Models;

namespace STUDIReplays2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReplaysController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReplaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Replays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Replay>>> GetReplays()
        {
            return await _context.Replays.ToListAsync();
        }

        // GET: api/Replays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Replay>> GetReplay(int id)
        {
            var replay = await _context.Replays.FindAsync(id);

            if (replay == null)
            {
                return NotFound();
            }

            return replay;
        }

        // PUT: api/Replays/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReplay(int id, Replay replay)
        {
            if (id != replay.Id)
            {
                return BadRequest();
            }

            _context.Entry(replay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReplayExists(id))
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

        // POST: api/Replays
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Replay>> PostReplay(Replay replay)
        {
            _context.Replays.Add(replay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReplay", new { id = replay.Id }, replay);
        }

        // DELETE: api/Replays/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReplay(int id)
        {
            var replay = await _context.Replays.FindAsync(id);
            if (replay == null)
            {
                return NotFound();
            }

            _context.Replays.Remove(replay);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReplayExists(int id)
        {
            return _context.Replays.Any(e => e.Id == id);
        }
    }
}
