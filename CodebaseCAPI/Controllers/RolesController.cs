using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : BaseEntitiesController<role>
    {
        public RolesController(IBaseService<role> context) : base(context) 
        {            
        }
    }
}
