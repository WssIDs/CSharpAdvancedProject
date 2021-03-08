using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpAdvancedProjectDAL.Context;
using CSharpAdvancedProjectDAL.Interfaces;
using CSharpAdvancedProjectDAL.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpAdvancedProjectDAL.Repositories
{
    /// <summary>
    /// Generic репозиторий
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public sealed class GenericRepository<TEntity> : IDisposable, IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly EmployeeContext _context;
        private bool _disposed;

        public GenericRepository(EmployeeContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>()
                .ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var local = await _context.Set<TEntity>()
                .FindAsync(entity.Id);

            if (local != null)
            {
                // detach
                _context.Entry(local).State = EntityState.Detached;
            }

            // set Modified flag in your entry
            _context.Entry(entity).State = EntityState.Modified;

            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
