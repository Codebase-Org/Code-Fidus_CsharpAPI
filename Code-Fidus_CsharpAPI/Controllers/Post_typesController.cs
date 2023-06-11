using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class Post_typesController : BaseEntitiesController<post_types>
    {
        public Post_typesController(DatabaseContext context) : base(context)
        {
        }
    }
}
