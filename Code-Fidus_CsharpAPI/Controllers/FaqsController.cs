using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class FaqsController : BaseEntitiesController<faqs>
    {
        public FaqsController(IBaseService<faqs> context) : base(context) 
        {            
        }
    }
}
