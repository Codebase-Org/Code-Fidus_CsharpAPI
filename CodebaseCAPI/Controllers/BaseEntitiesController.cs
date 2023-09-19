using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;
using Code_Fidus_CsharpAPI.Interfaces;

namespace Code_Fidus_CsharpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseEntitiesController<T> : ControllerBase where T: BaseEntity
    {
        private readonly IBaseService<T> _context;

        public BaseEntitiesController(IBaseService<T> context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEntities()
        {
            // List<T>
            var entities = await _context.GetEntitiesService();
            if (entities == null)
            {
                return NotFound();
            }
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEntity(int id)
        {
            // T
            var entity = await _context.GetEntityService(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEntity(int id, T entity) 
        {
            // bool
            if (id != entity.id)
            {
                return BadRequest("id != entity.id");
            }
            if (await _context.UpdateEntityService(id, entity))
            {
                return NoContent();
            }
            return NotFound("EntityExists(id) false");
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntity(T entity) 
        {
            // ingen returværdi lige pt.
            await _context.CreateEntityService(entity);
            return CreatedAtAction("GetEntity", new { id = entity.id }, entity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            // bool
            if(await _context.DeleteEntityService(id))
            {
                NoContent();
            }
            return NotFound("Entity == null");
        }
    }
}
