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

            return new ErrorResult("Hata");
        }

        public IResult Delete(Place place)
        {
            throw new NotImplementedException();
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
        
        public IDataResult<List<PlaceDetailDto>> GetPlaceDetails()
        {
            return new SuccessDataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetail(), Messages.PlaceListed);
        }
        [CacheRemoveAspect("ProductService.Get")]
        public IResult Update(Place place)
        {
            throw new NotImplementedException();
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
