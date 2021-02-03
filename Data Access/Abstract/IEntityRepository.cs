using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Data_Access.Abstract
{
    public interface IEntityRepository<T>
    {
        //generic constraint
        //class : referans tip
        //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
        //new() : new'lenebilir olmalı

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);

    }
}
