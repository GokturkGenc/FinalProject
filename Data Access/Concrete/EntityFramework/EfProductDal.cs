using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data_Access.Concrete.EntityFramework
{
    class EfProductDal : IProductDal
    {
        //NuGet: Kodların konulup ortak kullanıldığı mekan



        public void Add(Product entity)
        {
            //IDisposable pattern implamentation of c#

            using (NortwindContext context = new NortwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);

            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NortwindContext context=new NortwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();

            }
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            
        }
    }
}
