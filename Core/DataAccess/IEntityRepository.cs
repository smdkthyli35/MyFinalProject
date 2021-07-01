using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint : generic kısıtlamalar
    //class : referans tip olabilir demek. class olmalı demek değil!
    //IEntity : T ya IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı. (IEntity interface olduğu için newlenemez!)
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre vermeyedebilirsin demek.
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
