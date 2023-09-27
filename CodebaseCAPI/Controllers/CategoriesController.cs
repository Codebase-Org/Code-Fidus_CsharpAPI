using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class CategoriesController : BaseEntitiesController<category>
    {
        public CategoriesController(IBaseService<category> context) : base(context) 
        {            
        }
    }
}
