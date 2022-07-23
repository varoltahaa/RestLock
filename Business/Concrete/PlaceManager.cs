using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlaceManager : IPlaceService
    {
        IPlaceDal _placeDal;

        public PlaceManager(IPlaceDal placeDal)
        {
            _placeDal = placeDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(PlaceValidator))]
        [CacheRemoveAspect("ProductService.Get")]
        public IResult Add(Place place)
        {
            IResult result =  BusinessRules.Run(CheckNamePlace(place.PlaceName));
            if (result == null)
            {
                    _placeDal.Add(place);
                
                    return new SuccessResult(Messages.PlaceAdded);
            }

            return new ErrorResult(Messages.PlaceAddedError);
        }

        public IResult Delete(Place place)
        {
            _placeDal.Delete(place);
            return new SuccessResult();
        }
        [CacheAspect]
        public IDataResult<List<Place>> GetAll()
        {
            return new SuccessDataResult<List<Place>>(_placeDal.GetAll(),Messages.PlaceListed);
        }
        [CacheAspect]
        public IDataResult<List<Place>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Place>>(_placeDal.GetAll(p => p.PlaceCategoryId == categoryId), Messages.PlaceListed);
        }

        public IDataResult<Place> GetPlaceById(int id)
        {
            return new SuccessDataResult<Place>(_placeDal.Get(p=>p.PlaceId == id));
        }

        public IDataResult<List<PlaceDetailDto>> GetPlaceDetails(int placeId)
        {
            return new SuccessDataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetail(placeId), Messages.PlaceListed);
        }
        [CacheRemoveAspect("ProductService.Get")]
        public IResult Update(Place place)
        {
            IResult result = BusinessRules.Run(CheckNamePlace(place.PlaceName));

            if (result.Success)
            {
                _placeDal.Update(place);
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        private IResult CheckIfPlaceCountOfCategory(int categoryid) 
        {
            var result = _placeDal.GetAll(p => p.PlaceCategoryId == categoryid).Count;
            if (result >= 10)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IResult CheckNamePlace (string placeName) 
        {

            var result = _placeDal.GetAll(p => p.PlaceName == placeName).Any(); // .Any boolean döndürür. ilgili sorgu içerisinde istenilen eleman var mı onu kontrol eder.
            if (result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
