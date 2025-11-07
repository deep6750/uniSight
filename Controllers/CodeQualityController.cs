using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniSight.Models;

namespace UniSight.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CodeQualityController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CodeQualityController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CodeQuality>>> GetAll() => await _context.CodeQualities.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<CodeQuality>> Get(int id)
        {
            var item = await _context.CodeQualities.FindAsync(id);
            if (item == null) return NotFound();
            return item;
        }

        [HttpPost]
        public async Task<ActionResult<CodeQuality>> Create(CodeQuality item)
        {
            _context.CodeQualities.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.QualityRecordId }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CodeQuality item)
        {
            if (id != item.QualityRecordId) return BadRequest();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.CodeQualities.FindAsync(id);
            if (item == null) return NotFound();
            _context.CodeQualities.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

