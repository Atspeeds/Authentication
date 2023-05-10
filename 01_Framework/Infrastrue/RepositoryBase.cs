using _01_Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _01_Framework.Infrastrue
{
    public class RepositoryBase<TKey, T> : IRepositoryBase<TKey, T> where T : class
    {

        private DbContext _Context;

        public RepositoryBase(DbContext context)
        {
            _Context = context;
        }

        public void Create(T entity)
        {
            _Context.Add<T>(entity);
        }

        bool IRepositoryBase<TKey, T>.Exists(Expression<Func<T, bool>> expression)
        {
            return _Context.Set<T>().Any(expression);
        }

        T IRepositoryBase<TKey, T>.Get(TKey key)
        {
            return _Context.Set<T>().Find(key);
        }

        List<T> IRepositoryBase<TKey, T>.Get()
        {
            return _Context.Set<T>().ToList();
        }

        void IRepositoryBase<TKey, T>.Save()
        {
            _Context.SaveChanges();
        }
    }
}
