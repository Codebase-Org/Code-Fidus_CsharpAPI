using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class FaqsController : BaseEntitiesController<faq>
    {
        public FaqsController(IBaseService<faq> context) : base(context) 
        {            
        }
    }
}
