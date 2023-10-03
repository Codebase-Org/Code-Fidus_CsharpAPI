using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;

namespace CodebaseCAPI.Controllers
{
    public class EducationsController : BaseEntitiesController<education>
    {
        private readonly IBaseService<education> _context;

        public EducationsController(IBaseService<education> context) : base(context) 
        { 

        }
    }
}
