using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Code_Fidus_CsharpAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Code_Fidus_CsharpAPI.Controllers
{
    public class AccountsController : BaseEntitiesController<accounts>
    {
        private readonly IBaseService<accounts> _context;
        public AccountsController(IBaseService<accounts> context) : base(context) 
        {            
            //_context = context;
        }

        //[HttpGet("GetAccounts")]
        //public async Task<ActionResult<IEnumerable<accounts>>> GetAccounts()
        //{
        //    return await _context.accounts.ToListAsync();
        //}                
    }
}
