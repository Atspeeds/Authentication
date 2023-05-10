using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _01_Framework.Domain
{
    public interface IRepositoryBase<TKey,T> where T : class
    {
        T Get(TKey key);
        void Save();
        List<T> Get();
        bool Exists(Expression<Func<T,bool>> expression);
        void Create(T entity);


    }
}
