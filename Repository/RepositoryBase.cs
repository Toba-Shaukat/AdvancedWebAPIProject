using Contracts;
using Entities.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;

namespace Repository
{
    public abstract class RepositoryBase<TModel> : IRepositoryBase<TModel> where TModel : class
    {
        private readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        public void Add(TModel model)
        {
            //_context.Pages.Add(model)
            _context.Set<TModel>().Add(model);
        }

        //IEnumerable: processing will happen in the memory
        //IQueryable: processing wil happen in the database
        public IQueryable<TModel> FindAll(bool trackChanges)
        {
            var data = _context.Set<TModel>().AsQueryable();

            if (trackChanges)
            {
                return data;
            }

            return data.AsNoTracking();
        }

        public IQueryable<TModel> FindByCondition(Expression<Func<TModel, bool>> expression, bool trackChanges)
        {
            if(!trackChanges) {
                return _context.Set<TModel>().Where(expression).AsNoTracking();
            }

            return _context.Set<TModel>().Where(expression);
        }

        public void Remove(TModel model)
        {
            _context.Set<TModel>().Remove(model);
        }

        public void Update(TModel model)
        {
            _context.Set<TModel>().Update(model);
        }
    }
}
