using Code_Fidus_CsharpAPI.Models;

namespace Code_Fidus_CsharpAPI.Interfaces
{
    public interface IBaseService
    {
        Task<BaseEntity> GetEntitiesServ(BaseEntity entity);
        Task<BaseEntity> CreateAsync(BaseEntity entity);
    }
}
