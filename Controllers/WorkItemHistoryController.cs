
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniSight.Models;

namespace UniSight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkItemHistoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WorkItemHistoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkItemHistory>>> GetAll() => await _context.WorkItemHistories.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkItemHistory>> Get(int id)
        {
            var item = await _context.WorkItemHistories.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<WorkItemHistory>> Create(WorkItemHistory item)
        {
            _context.WorkItemHistories.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.HistoryId }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, WorkItemHistory item)
        {
            if (id != item.HistoryId) return BadRequest();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.WorkItemHistories.FindAsync(id);
            if (item == null) return NotFound();
            _context.WorkItemHistories.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
