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
            _placeCategoryDal.Add(placeCategory);
            return new SuccessResult();
        }

        public IResult Delete(PlaceCategory placeCategory)
        {
            _placeCategoryDal.Delete(placeCategory);
            return new SuccessResult();
        }

        public IDataResult<PlaceCategory> Get(int id)
        {
            return new SuccessDataResult<PlaceCategory>(_placeCategoryDal.Get(p => p.PlaceCategoryId ==id));
        }

        public IDataResult<List<PlaceCategory>> GetAll()
        {
            return new SuccessDataResult<List<PlaceCategory>>(_placeCategoryDal.GetAll());
        }

        public IResult Update(PlaceCategory placeCategory)
        {
            _placeCategoryDal.Update(placeCategory);
            return new SuccessResult();
        }
    }
}
