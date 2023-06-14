using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Models;

namespace Code_Fidus_CsharpAPI.Services
{
    public class BaseService<T> where T : BaseEntity
    {
        protected readonly DatabaseContext _context;

        public BaseService(DatabaseContext context)
        {
            _context = context;
        }

        //protected 
    }
}
