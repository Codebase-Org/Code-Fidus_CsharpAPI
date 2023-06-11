using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class LoginhistoriesController : BaseEntitiesController<loginhistories>
    {
        public LoginhistoriesController(DatabaseContext context) : base(context) 
        {            
        }
    }
}
