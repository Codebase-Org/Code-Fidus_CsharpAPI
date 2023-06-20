using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;

namespace Code_Fidus_CsharpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseEntitiesController<T> : ControllerBase where T: BaseEntity
    {
        private readonly DatabaseContext _context;

        public BaseEntitiesController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEntities()
        {
            var entities = await _context.Set<T>().ToListAsync();
            if (entities == null)
            {
                return NotFound();
            }
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEntity(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEntity(int id, T entity) // Fungere ikke
        {
            if (id != entity.id)
            {
                return BadRequest("if id != entity.id");
            }

            if (!await EntityExists(id))
            {
                return NotFound("if EntityExists(id)");
            }

            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntity(T entity) 
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetEntity", new { id = entity.id }, entity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return NotFound("if entity == null");
            }           

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private Task<bool> EntityExists(int id)
        {
            var entityType = typeof(T);
            var idPropertyName = entityType.GetProperties().FirstOrDefault(p => p.Name.EndsWith("id")).Name.ToString();
            //var test = _context.roles.AnyAsync(e => Convert.ToInt32(entityType.GetProperty(idPropertyName[1]).GetValue(e)) == id);
            var et = entityType.GetProperty(idPropertyName);

            var tt = _context.roles.FirstOrDefault(i => i.role_id == id);
            var test = _context.Set<T>().AnyAsync(e => e.GetType().GetProperties().FirstOrDefault(p => p.Name.EndsWith("id")).Name == "" + id);
            
            //p.Name.Equals("id", StringComparison.OrdinalIgnoreCase))?.Name;
            //return _context.Set<T>().AnyAsync(e => e.id == id);
            return Task.FromResult(false);
        }
    }
}
