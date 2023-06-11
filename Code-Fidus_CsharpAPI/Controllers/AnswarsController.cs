using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class AnswarsController : BaseEntitiesController<answars>
    {
        public AnswarsController(DatabaseContext context) : base(context) 
        {            
        }
    }
}
