using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : BaseEntitiesController<roles>
    {
        public RolesController(IBaseService<roles> context) : base(context) 
        {            
        }
    }
}
