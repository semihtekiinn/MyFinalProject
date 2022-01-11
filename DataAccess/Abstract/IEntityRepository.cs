using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint - Generic kısıtlama 
    //class : referans tip 
    //IEntity : IEntity ya da IEntity implamente eden bir nesne olabilir. 
    //new () : newlenebilir olmalı .  IEntity nin verilememesi için new() özelliğini ekledik. İnterfaceler newlenemediği için IEntity de yazılamaz . 

    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity); 
    }
}
