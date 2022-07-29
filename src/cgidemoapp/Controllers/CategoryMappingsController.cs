using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cgidemoapp.Data;
using cgidemoapp.Models;

namespace cgidemoapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMappingsController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoryMappingsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CategoryMappings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryMapping>>> GetCategoryMappings()
        {
          if (_context.CategoryMappings == null)
          {
              return NotFound();
          }
            return await _context.CategoryMappings.ToListAsync();
        }

        // GET: api/CategoryMappings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryMapping>> GetCategoryMapping(int id)
        {
          if (_context.CategoryMappings == null)
          {
              return NotFound();
          }
            var categoryMapping = await _context.CategoryMappings.FindAsync(id);

            if (categoryMapping == null)
            {
                return NotFound();
            }

            return categoryMapping;
        }

        // PUT: api/CategoryMappings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoryMapping(int id, CategoryMapping categoryMapping)
        {
            if (id != categoryMapping.ParentCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(categoryMapping).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryMappingExists(id))
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

        // POST: api/CategoryMappings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoryMapping>> PostCategoryMapping(CategoryMapping categoryMapping)
        {
          if (_context.CategoryMappings == null)
          {
              return Problem("Entity set 'DataContext.CategoryMappings'  is null.");
          }
            _context.CategoryMappings.Add(categoryMapping);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CategoryMappingExists(categoryMapping.ParentCategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategoryMapping", new { id = categoryMapping.ParentCategoryId }, categoryMapping);
        }

        // DELETE: api/CategoryMappings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryMapping(int id)
        {
            if (_context.CategoryMappings == null)
            {
                return NotFound();
            }
            var categoryMapping = await _context.CategoryMappings.FindAsync(id);
            if (categoryMapping == null)
            {
                return NotFound();
            }

            _context.CategoryMappings.Remove(categoryMapping);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryMappingExists(int id)
        {
            return (_context.CategoryMappings?.Any(e => e.ParentCategoryId == id)).GetValueOrDefault();
        }
    }
}
