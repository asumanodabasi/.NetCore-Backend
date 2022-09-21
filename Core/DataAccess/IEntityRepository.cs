using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint
    // class demek "referans tip " demek
    // IEntity : IEntity olabilir (yani bu bir veri tabanı tablosu olacak demek) veya IEntity implument eden bir nesne olabilir
    // new() : new'lenebilir olmalı
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Filtre vermeden tum datayı getir demek.Linq ile oluşturduk. 

        T Get(Expression<Func<T, bool>> filter); //Datayı filtreleyip verecek
        
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        
    }
}
