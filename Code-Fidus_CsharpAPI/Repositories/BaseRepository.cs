using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Code_Fidus_CsharpAPI.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        // I Repository skal hentes entiteten som den er i databasen.

        private readonly DatabaseContext _context;
        public BaseRepository(DatabaseContext context)
        {
            _context = context;
        }        

        public async Task<List<T>> GetEntitiesRepository()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetEntityRepository(int id)
        {
            return await _context.Set<T>().FindAsync(id);
            
        }

        public async Task<bool> UpdateEntityRepository(int id, T entity)
        {
            if (!await EntityExists(id))
            {
                return false;
            }

            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task CreateEntityRepository(T entity)
        {
            await _context.Set<T>().AddAsync(entity); // Intellisence nonsense (T)
            await _context.SaveChangesAsync();            
            // HMM, what to do here?
        }

        public async Task<bool> DeleteEntityRepository(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return false;
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }

        private Task<bool> EntityExists(int id)
        {
            var entityType = typeof(T);
            var idPropertyName = entityType.GetProperties().FirstOrDefault(p => p.Name.EndsWith("id")).Name.ToString();
            //var test = _context.roles.AnyAsync(e => Convert.ToInt32(entityType.GetProperty(idPropertyName[1]).GetValue(e)) == id);
            var et = entityType.GetProperty(idPropertyName);

            var tt = _context.roles.FirstOrDefault(i => i.role_id == id);
            var test = _context.Set<T>().AnyAsync(e => e.GetType().GetProperties().FirstOrDefault(p => p.Name.EndsWith("id")).Name == "" + id);

            //p.Name.Equals("id", StringComparison.OrdinalIgnoreCase))?.Name;
            //return _context.Set<T>().AnyAsync(e => e.id == id);
            return Task.FromResult(false);
        }

        public async Task<List<posts>> searchPostsRepository(string? value, int? categoryId, int? typeId, bool viewsSorted)
        {
            IQueryable<posts> query = _context.posts;

            if(!string.IsNullOrEmpty(value))
            {
                query = query.Where(post => post.post_headline.Contains(value) || post.post_content.Contains(value));
            }
            if(categoryId.HasValue)
            {
                query = query.Where(post => post.category_id == categoryId);
            }
            if (typeId.HasValue)
            {
                query = query.Where(post => post.post_type_id == typeId);
            }
            if (viewsSorted)
            {
                query = query.OrderByDescending(post => post.post_views);
            }
            return await query.ToListAsync();
        }
    }
}
