using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class FollowsController : BaseEntitiesController<follows>
    {
        public FollowsController(IBaseService<follows> context) : base(context) 
        {            
        }
    }
}
