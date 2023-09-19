using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using CodebaseCAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodebaseCAPI.Controllers
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
