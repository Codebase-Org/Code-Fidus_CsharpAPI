using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class AnswarsController : BaseEntitiesController<answar>
    {
        public AnswarsController(IBaseService<answar> context) : base(context) 
        {            
        }
    }
}
