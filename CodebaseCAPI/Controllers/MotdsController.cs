using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class MotdsController : BaseEntitiesController<motds>
    {
        public MotdsController(IBaseService<motds> context) : base(context) 
        {            
        }
    }
}
