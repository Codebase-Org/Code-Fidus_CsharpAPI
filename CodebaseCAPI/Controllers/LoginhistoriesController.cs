using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class LoginhistoriesController : BaseEntitiesController<loginhistories>
    {
        public LoginhistoriesController(IBaseService<loginhistories> context) : base(context) 
        {            
        }
    }
}
