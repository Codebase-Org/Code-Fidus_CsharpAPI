using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<List<T>> GetEntitiesService();
        Task<T> GetEntityService(int id);
        Task<bool> UpdateEntityService(int id, BaseEntity entity);
        Task CreateEntityService(BaseEntity entity);
        Task<bool> DeleteEntityService(int id);
        Task<List<posts>> searchPostsService(string value, int categoryId, int typeId, bool viewsSorted);
    }
}
