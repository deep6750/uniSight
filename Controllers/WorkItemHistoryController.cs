
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
<<<<<<< HEAD
        public async Task<ActionResult<IEnumerable<WorkItemHistory>>> GetAll() => await _context.WorkItemHistories.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkItemHistory>> Get(Guid id)
=======
        public async Task<ActionResult<IEnumerable<WorkItemHistory>>> GetAll() => await _context.WorkItemHistories.AsNoTracking().ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkItemHistory>> Get(int id)
>>>>>>> a21b911 (Align EF models with existing schema)
        {
            var item = await _context.WorkItemHistories.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<WorkItemHistory>> Create(WorkItemHistory item)
        {
<<<<<<< HEAD
            item.Id = Guid.NewGuid();
            _context.WorkItemHistories.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, WorkItemHistory item)
        {
            if (id != item.Id) return BadRequest();
=======
            _context.WorkItemHistories.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.HistoryId }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, WorkItemHistory item)
        {
            if (id != item.HistoryId) return BadRequest();
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
            var item = await _context.WorkItemHistories.FindAsync(id);
            if (item == null) return NotFound();
            _context.WorkItemHistories.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
