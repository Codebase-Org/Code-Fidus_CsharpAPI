using CodebaseCAPI.Database;
using CodebaseCAPI.Interfaces;
using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit.Sdk;

namespace CodebaseCAPI.Repositories
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

        public async Task<List<post>> searchPostsRepository(string? value, int? categoryId, int? typeId, bool viewsSorted)
        {
            IQueryable<post> query = _context.posts;

            //if (!string.IsNullOrEmpty(value))
            //{
            //    query = query.Where(post => post.post_headline.Contains(value) || post.post_content.Contains(value));
            //}
            if (!string.IsNullOrEmpty(value))
            {
                string[] terms = value.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var matchPosts = await query.ToListAsync();

                // finder umiddelbart de posts der matcher ud fra flere termer.
                matchPosts = matchPosts.Where(post => terms.Any(term => post.post_headline.Contains(term) || post.post_content.Contains(term))).ToList();

                foreach (var item in matchPosts)
                {
                    foreach(var term in terms)
                    {
                        // Logik til hvad der skal ske hvis der er flere matches.
                        int indexHeadline = item.post_headline.ToLower().IndexOf(term.ToLower());
                        while(indexHeadline != -1)
                        {
                            item.matchCount++;
                            indexHeadline = item.post_headline.ToLower().IndexOf(term.ToLower(), indexHeadline + 1);
                        }

                        int indexContent = item.post_headline.ToLower().IndexOf(term.ToLower());
                        while (indexContent != -1)
                        {
                            item.matchCount++;
                            indexContent = item.post_headline.ToLower().IndexOf(term.ToLower(), indexContent + 1);
                        }

                    }
                }

                //foreach (var term in terms)
                //{
                    
                //    query = query.Where(post => post.post_headline.Contains(term) || post.post_content.Contains(term));
                //    //query = query.Select(post => new
                //    //{
                //    //    Post = post,
                //    //    HeadlineMatches = post.post_headline.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count(word => word.Contains(term)),
                //    //    ContentMatches = post.post_content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Count(word => word.Contains(term))
                //    //}).Where(postWithMatches => postWithMatches.HeadlineMatches > 0 || postWithMatches.ContentMatches > 0).Select(postWithMatches => postWithMatches.Post);
                //}
            }
            if (categoryId.HasValue)
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
