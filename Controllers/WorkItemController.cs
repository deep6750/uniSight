
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniSight.Models;

namespace UniSight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkItemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WorkItemController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<WorkItem>>> GetAll() => await _context.WorkItems.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkItem>> Get(Guid id)
=======
        public async Task<ActionResult<IEnumerable<WorkItem>>> GetAll() => await _context.WorkItems.AsNoTracking().ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkItem>> Get(int id)
>>>>>>> a21b911 (Align EF models with existing schema)
        {
            var item = await _context.WorkItems.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<WorkItem>> Create(WorkItem item)
        {
<<<<<<< HEAD
            item.Id = Guid.NewGuid();
            _context.WorkItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, WorkItem item)
        {
            if (id != item.Id) return BadRequest();
=======
            if (await _context.WorkItems.AnyAsync(w => w.WorkItemId == item.WorkItemId))
            {
                return Conflict($"Work item {item.WorkItemId} already exists.");
            }
            _context.WorkItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.WorkItemId }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, WorkItem item)
        {
            if (id != item.WorkItemId) return BadRequest();
>>>>>>> a21b911 (Align EF models with existing schema)
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
            var item = await _context.WorkItems.FindAsync(id);
            if (item == null) return NotFound();
            _context.WorkItems.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
