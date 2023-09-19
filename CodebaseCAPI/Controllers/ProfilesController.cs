using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class ProfilesController : BaseEntitiesController<profiles>
    {
        public ProfilesController(IBaseService<profiles> context) : base(context) 
        {            
        }
    }
}
