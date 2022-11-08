using System;
using System.Linq;
using System.Linq.Expressions;

namespace Contracts
{
    public interface IRepositoryBase<TModel> where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        IQueryable<TModel> FindAll(bool trackChanges);
        IQueryable<TModel> FindByCondition(Expression<Func<TModel, bool>> expression, bool trackChanges);
        void Remove(TModel model);
    }
}
