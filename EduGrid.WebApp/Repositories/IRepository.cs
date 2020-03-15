using EduGrid.ModelService.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EduGrid.WebApp.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        T Add(T t);
        Task<T> AddAsync(T t);
        int Count();
        Task<int> CountAsync();
        void Delete(T t);
        Task DeleteAsync(T t);
        void Dispose();
        T Find(Expression<Func<T, bool>> match);
        //IEnumerable<T> FindAll(Expression<Func<T, bool>> match);
        //Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        T Get(object id);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(object id);
        void Save();
        Task SaveAsync();
        T Update(T t, object id);
        Task<T> UpdateAsync(T t, object id);
    }
}
