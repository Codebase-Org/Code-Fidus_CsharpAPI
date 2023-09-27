using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class PostsController : BaseEntitiesController<post>
    {
        IBaseService<post> _context;
        public PostsController(IBaseService<post> context) : base(context) 
        {            
            _context = context; 
        }
            
        [HttpGet("SearchPosts")]
        public async Task<ActionResult<IEnumerable<post>>> SearchPosts([FromQuery] string? value, [FromQuery] int? categoryId, [FromQuery] int? typeId, [FromQuery] bool viewsSorted = false)
        {            
            return Ok(await _context.searchPostsService(value, categoryId, typeId, viewsSorted));
        }
    }
}
