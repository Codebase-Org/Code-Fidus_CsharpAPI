using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Controllers
{
    public class Post_typesController : BaseEntitiesController<post_type>
    {
        public Post_typesController(IBaseService<post_type> context) : base(context)
        {
        }
    }
}
