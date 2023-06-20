using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

            if(!await EntityExists(id))
            {
                return NotFound("if EntityExists(id)");
            }

            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntity(T entity) // Giver http 500 status, på succesfuld create.
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            Console.WriteLine("Vi prøver at create...");
            return CreatedAtAction("Detail", new { id = entity.id }, entity);
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
            return _context.Set<T>().AnyAsync(e => e.id == id);
        }
    }
}
