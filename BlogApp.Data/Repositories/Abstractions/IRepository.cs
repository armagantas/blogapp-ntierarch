using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity); 
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByGuidAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }
}

// AddAsync : Add a entity
// GetAllAsync : It is used to retrieve all entities or filter based on a specific condition and load associated data.
// GetAsync : It is used to fetch the first entity that meets a certain condition and load the associated data.
// GetByGuidAsync : It is used to fetch the entity with a specific GUID value.
// Update Async : Update a entity.
// Delete Async : Delete a entity.
// AnyAsync : It is used to check whether an entity meets a certain condition.
// CountAsync : It is used to get the number of entities based on a certain condition.