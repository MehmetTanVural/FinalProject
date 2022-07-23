using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint -- generic kısıt demek
    //IEntity olabilir veya IEntity implement eden bir nesne olabilir
    //new() lenebilir olmalı
    public interface IEntityRepository<T> where T: class,IEntity,new() //IEntityRepository alacağı değerleri kısıtladık
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //Expression filtreleme sağlar( tüm bu kod categoryid == 2 yerine geçer mesela)
        T Get(Expression<Func<T, bool>> filter); //Tek bir data getirmek için oluşturuldu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
