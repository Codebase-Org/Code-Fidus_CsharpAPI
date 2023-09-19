using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class MessagesController : BaseEntitiesController<messages>
    {
        public MessagesController(IBaseService<messages> context) : base(context) 
        {            
        }
    }
}
