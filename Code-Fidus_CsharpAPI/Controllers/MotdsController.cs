using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class MotdsController : BaseEntitiesController<motds>
    {
        public MotdsController(DatabaseContext context) : base(context) 
        {            
        }
    }
}
