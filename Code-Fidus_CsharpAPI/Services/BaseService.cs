﻿using Code_Fidus_CsharpAPI.Database;
using Code_Fidus_CsharpAPI.Interfaces;
using Code_Fidus_CsharpAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Fidus_CsharpAPI.Services
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

        public async Task<bool> UpdateEntityService(int id, BaseEntity entity)
        {
            return await _context.UpdateEntityRepository(id, entity);
        }

        public async Task CreateEntityService(BaseEntity entity)
        {
            await _context.CreateEntityRepository(entity);
        }

        public async Task<bool> DeleteEntityService(int id)
        {
            return await _context.DeleteEntityRepository(id);
        }
    }
}
