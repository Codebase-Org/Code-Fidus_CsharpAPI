using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class FollowsController : BaseEntitiesController<follows>
    {
        public FollowsController(IBaseService<follows> context) : base(context) 
        {            
        }
    }
}
