using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetEntitiesRepository();
        Task<T> GetEntityRepository(int id);
        Task<bool> UpdateEntityRepository(int id, T entity);
        Task CreateEntityRepository(T entity);
        Task<bool> DeleteEntityRepository(int id);
        Task<List<posts>> searchPostsRepository(string value, int? categoryId, int? typeId, bool viewsSorted);
    }
}
