using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    // where kısmında yaptığımız işlem :
    // T olarak gönderilecek nesne class olmalı, IEntityden çağrılmalı ve new lenebilir olması lazım
    // IEntity interface olduğu için new lenemez bu nedenle direk entitesler kullanılabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
