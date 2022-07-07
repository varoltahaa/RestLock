using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlaceCategoryManager : IPlaceCategoryService
    {

        IPlaceCategoryDal _ıPlaceCategoryDal;
        public PlaceCategoryManager(IPlaceCategoryDal placeCategoryDal)
        {
            _ıPlaceCategoryDal = placeCategoryDal;
        }
        public void Add(PlaceCategory placeCategory)
        {
            throw new NotImplementedException();
        }

        public void Delete(PlaceCategory placeCategory)
        {
            throw new NotImplementedException();
        }

        public PlaceCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<PlaceCategory> GetAll()
        {
            return _ıPlaceCategoryDal.GetAll();
        }

        public void Update(PlaceCategory placeCategory)
        {
            throw new NotImplementedException();
        }
    }
}
