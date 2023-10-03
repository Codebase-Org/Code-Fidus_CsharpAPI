using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class Login_historiesController : BaseEntitiesController<login_history>
    {
        public Login_historiesController(IBaseService<login_history> context) : base(context) 
        {            
        }
    }
}
