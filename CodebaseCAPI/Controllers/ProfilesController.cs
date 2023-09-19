using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class ProfilesController : BaseEntitiesController<profiles>
    {
        public ProfilesController(IBaseService<profiles> context) : base(context) 
        {            
        }
    }
}
