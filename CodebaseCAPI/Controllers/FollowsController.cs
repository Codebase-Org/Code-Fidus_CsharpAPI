using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class FollowsController : BaseEntitiesController<follow>
    {
        public FollowsController(IBaseService<follow> context) : base(context) 
        {            
        }
    }
}
