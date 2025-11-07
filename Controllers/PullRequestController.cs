
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
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<PullRequest>>> GetAll() => await _context.PullRequests.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<PullRequest>> Get(Guid id)
=======
        public async Task<ActionResult<IEnumerable<PullRequest>>> GetAll() => await _context.PullRequests.AsNoTracking().ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<PullRequest>> Get(int id)
>>>>>>> a21b911 (Align EF models with existing schema)
        {
            var item = await _context.PullRequests.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<PullRequest>> Create(PullRequest item)
        {
<<<<<<< HEAD
            item.Id = Guid.NewGuid();
=======
            if (await _context.PullRequests.AnyAsync(p => p.Id == item.Id))
            {
                return Conflict($"Pull request {item.Id} already exists.");
            }
>>>>>>> a21b911 (Align EF models with existing schema)
            _context.PullRequests.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
<<<<<<< HEAD
        public async Task<IActionResult> Update(Guid id, PullRequest item)
=======
        public async Task<IActionResult> Update(int id, PullRequest item)
>>>>>>> a21b911 (Align EF models with existing schema)
        {
            if (id != item.Id) return BadRequest();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
<<<<<<< HEAD
        public async Task<IActionResult> Delete(Guid id)
=======
        public async Task<IActionResult> Delete(int id)
>>>>>>> a21b911 (Align EF models with existing schema)
        {
            var item = await _context.PullRequests.FindAsync(id);
            if (item == null) return NotFound();
            _context.PullRequests.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
