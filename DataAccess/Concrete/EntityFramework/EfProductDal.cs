using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext()) //NorthwindContext pahalı bir nesne o yuzden using kullandık işi bitince bellekten atılacak demek
            {
                var addedEntity = context.Entry(entity);  //referansı yakala    //veri kaynağından benim gönderdiğim producttan bi tane nesne eslestir
                addedEntity.State = EntityState.Added; //o aslında eklenecek bir nesne
                context.SaveChanges();   // ve simdi ekle //SaveChanges burdaki butun işlemleri yap demek
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) 
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted; 
                context.SaveChanges();  
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();   // ? bu işaret filter==null sa 1. sini ,degilse 2. sini çalistirir.
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) 
            {
                var updatedEntity = context.Entry(entity); 
                updatedEntity.State = EntityState.Modified; 
                context.SaveChanges();   
            }
        }
    }
}
