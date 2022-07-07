using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
   //where T: class = böyle yaparak "int, string, char, decimal" gibi sınıfları eklemeyi engelleriz sadece referans tipleri kabul eder.
   //devamında eklediğimiz IEntity sadece Entity katmanımızdaki IEntity ve IEntity interfacinden referans alan classları implemente edebilir.
   //new() = bunu yazmamızdaki amaç ise IEntity interfacinide almamasını sağlamak. Interfaceler newlemediği için kullananılamaz ve bu sayede sadece Entity katmanımızdaki classları alabilmek için filtreleme yapabilcez.
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
 