using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class AnswarsController : BaseEntitiesController<answars>
    {
        public AnswarsController(IBaseService<answars> context) : base(context) 
        {            
        }
    }
}
