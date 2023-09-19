using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        // I Service kan der vælges hvad der skal ud til controller.

        protected readonly IBaseRepository<T> _context;

        public BaseService(IBaseRepository<T> context)
        {
            _context = context;
        }        

        public async Task<List<T>> GetEntitiesService()
        {
            return await _context.GetEntitiesRepository();
        }

        public async Task<T> GetEntityService(int id)
        {
            return await _context.GetEntityRepository(id);
        }

        public async Task<bool> UpdateEntityService(int id, T entity)
        {
            return await _context.UpdateEntityRepository(id, entity);
        }

        public async Task CreateEntityService(T entity)
        {
            await _context.CreateEntityRepository(entity);
        }

        public async Task<bool> DeleteEntityService(int id)
        {
            return await _context.DeleteEntityRepository(id);
        }

        public async Task<List<posts>> searchPostsService(string? value, int? categoryId, int? typeId, bool viewsSorted)
        {
            return await _context.searchPostsRepository(value, categoryId, typeId, viewsSorted);
        }
    }
}
