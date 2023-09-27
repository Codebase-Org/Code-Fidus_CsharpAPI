using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class LoginhistoriesController : BaseEntitiesController<login_history>
    {
        public LoginhistoriesController(IBaseService<login_history> context) : base(context) 
        {            
        }
    }
}
