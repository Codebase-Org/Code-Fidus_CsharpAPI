using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
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
