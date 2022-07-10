using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
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
        [ValidationAspect(typeof(PlaceValidator))]
        public IResult Add(Place place)
        {

            _placeDal.Add(place);
            return new SuccessResult(Messages.PlaceAdded);
        }

        public IResult Delete(Place place)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Place>> GetAll()
        {
            return new SuccessDataResult<List< Place >>(_placeDal.GetAll(),Messages.PlaceListed);
        }

        public IDataResult<List<Place>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Place>>(_placeDal.GetAll(p => p.PlaceCategoryId == categoryId), Messages.PlaceListed);
        }

        public IDataResult<List<PlaceDetailDto>> GetPlaceDetails()
        {
            return new SuccessDataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetail(), Messages.PlaceListed);
        }

        public IResult Update(Place place)
        {
            throw new NotImplementedException();
        }
    }
}
