using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class PostsController : BaseEntitiesController<posts>
    {
        public PostsController(IBaseService<posts> context) : base(context) 
        {            
        }
    }
}
