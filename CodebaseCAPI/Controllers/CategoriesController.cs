using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class CategoriesController : BaseEntitiesController<categories>
    {
        public CategoriesController(IBaseService<categories> context) : base(context) 
        {            
        }
    }
}
