
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniSight.Models;

namespace UniSight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PullRequestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PullRequestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PullRequest>>> GetAll() => await _context.PullRequests.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<PullRequest>> Get(int id)
        {
            var item = await _context.PullRequests.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<PullRequest>> Create(PullRequest item)
        {
            _context.PullRequests.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PullRequest item)
        {
            if (id != item.Id) return BadRequest();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.PullRequests.FindAsync(id);
            if (item == null) return NotFound();
            _context.PullRequests.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
