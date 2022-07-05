using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlaceCategoryDal : IPlaceCategoryDal
    {
        public void Add(PlaceCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PlaceCategory entity)
        {
            throw new NotImplementedException();
        }

        public PlaceCategory Get(Expression<Func<PlaceCategory, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<PlaceCategory> GetAll(Expression<Func<PlaceCategory, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(PlaceCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
