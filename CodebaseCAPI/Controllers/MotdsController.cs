using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class MotdsController : BaseEntitiesController<motd>
    {
        public MotdsController(IBaseService<motd> context) : base(context) 
        {            
        }
    }
}
