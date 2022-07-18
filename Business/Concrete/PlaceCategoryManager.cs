using Business.Abstract;
using Core.Utilities.Results;
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
        IPlaceCategoryDal _placeCategoryDal;
        public PlaceCategoryManager(IPlaceCategoryDal placeCategoryDal)
        {
            _placeCategoryDal = placeCategoryDal;
        }
        public IResult Add(PlaceCategory placeCategory)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PlaceCategory placeCategory)
        {
            throw new NotImplementedException();
        }

        public IDataResult<PlaceCategory> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PlaceCategory>> GetAll()
        {
            return new SuccessDataResult<List<PlaceCategory>>(_placeCategoryDal.GetAll());
        }

        public IResult Update(PlaceCategory placeCategory)
        {
            throw new NotImplementedException();
        }
    }
}
