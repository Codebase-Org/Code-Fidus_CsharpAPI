using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class PostsController : BaseEntitiesController<posts>
    {
        IBaseService<posts> _context;
        public PostsController(IBaseService<posts> context) : base(context) 
        {            
            _context = context; 
        }
            
        [HttpGet("SearchPosts")]
        public async Task<ActionResult<IEnumerable<posts>>> SearchPosts([FromQuery] string? value, [FromQuery] int? categoryId, [FromQuery] int? typeId, [FromQuery] bool viewsSorted = false)
        {            
            return Ok(await _context.searchPostsService(value, categoryId, typeId, viewsSorted));
        }
    }
}
