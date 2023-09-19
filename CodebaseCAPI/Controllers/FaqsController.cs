using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class FaqsController : BaseEntitiesController<faqs>
    {
        public FaqsController(IBaseService<faqs> context) : base(context) 
        {            
        }
    }
}
