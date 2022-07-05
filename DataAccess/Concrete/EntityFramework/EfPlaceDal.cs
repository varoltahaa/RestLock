using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlaceDal : IPlaceDal
    {
        public void Add(Place entity)
        {
            
            using (RestLockContext context = new RestLockContext())
            {
                var addedEntity = context.Entry(entity); //Burada eklenecek nesnenin referansını yakalıyoruz
                addedEntity.State = EntityState.Added;  // Burada onun ekleneceğini belirtiyoruz
                context.SaveChanges();                  // Burada ise ekliyoruz
            }
        }

        public void Delete(Place entity)
        {
            using (RestLockContext context = new RestLockContext())
            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted; 
                context.SaveChanges();
            }
        }

        public Place Get(Expression<Func<Place, bool>> filter)
        {
            using (RestLockContext context = new RestLockContext())
            {
                return context.Set<Place>().SingleOrDefault(filter);
            }
        }

        public List<Place> GetAll(Expression<Func<Place, bool>> filter = null)
        {
            using (RestLockContext context = new RestLockContext())
            {
                return filter == null ? context.Set<Place>().ToList() : context.Set<Place>().Where(filter).ToList();

            }
        }

        public void Update(Place entity)
        {
            using (RestLockContext context = new RestLockContext())
            {
                var uptatedEntity = context.Entry(entity);
                uptatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
