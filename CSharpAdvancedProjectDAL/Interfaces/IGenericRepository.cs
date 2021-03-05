using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpAdvancedProjectDAL.Interfaces.Entities;

namespace CSharpAdvancedProjectDAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(int id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
