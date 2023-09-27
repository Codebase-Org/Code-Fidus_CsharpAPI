using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class MessagesController : BaseEntitiesController<message>
    {
        public MessagesController(IBaseService<message> context) : base(context) 
        {            
        }
    }
}
