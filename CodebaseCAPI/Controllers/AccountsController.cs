using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using CodebaseCAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodebaseCAPI.Controllers
{
    public class AccountsController : BaseEntitiesController<account>
    {
        private readonly IBaseService<account> _context;
        public AccountsController(IBaseService<account> context) : base(context) 
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
