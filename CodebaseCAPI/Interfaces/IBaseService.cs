using CodebaseCAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodebaseCAPI.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<List<T>> GetEntitiesService();
        Task<T> GetEntityService(int id);
        Task<bool> UpdateEntityService(int id, T entity);
        Task CreateEntityService(T entity);
        Task<bool> DeleteEntityService(int id);
        Task<List<post>> searchPostsService(string? value, int? categoryId, int? typeId, bool viewsSorted);
    }
}
