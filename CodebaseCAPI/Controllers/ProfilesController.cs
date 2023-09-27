using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class ProfilesController : BaseEntitiesController<profile>
    {
        public ProfilesController(IBaseService<profile> context) : base(context) 
        {            
        }
    }
}
