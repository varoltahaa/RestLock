using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlaceImageManager : IPlaceImageService
    {
        IPlaceImageDal _placeImageDal;
        IFileHelper _fileHelper;

        public PlaceImageManager(IPlaceImageDal placeImageDal, IFileHelper fileHelper)
        {
            _placeImageDal = placeImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, PlaceImage placeImage)
        {
            IResult result = BusinessRules.Run(CheckIfPlaceImageLimit(placeImage.PlaceId));
            if (result!=null)
            {
                return result;
            }

            placeImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            placeImage.Date = DateTime.Now;
            _placeImageDal.Add(placeImage);
            return new SuccessResult("Resim Başarıyla Yüklendi");
        }

        public IResult Delete(PlaceImage placeImage)
        {
            _placeImageDal.Delete(placeImage);
            return new SuccessResult();
        }

        public IDataResult<List<PlaceImage>> GetAll()
        {
            return new SuccessDataResult<List<PlaceImage>>(_placeImageDal.GetAll());
        }

        public IDataResult<List<PlaceImage>> GetByPlaceId(int placeId)
        {
            if (!CheckPlaceImage(placeId))
            {
                return new ErrorDataResult<List<PlaceImage>>(GetDefaultImage(placeId).Data);
            }
            List<PlaceImage> list = _placeImageDal.GetAll(p => p.PlaceId == placeId);
            foreach (var item in list)
            {
                item.ImagePath = "https://localhost:44333/api/PlaceImages/getimage?imagePath=" + item.ImagePath;
            }
            return new SuccessDataResult<List<PlaceImage>>(list);
        }

        public IDataResult<PlaceImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<PlaceImage>(_placeImageDal.Get(p => p.ImageId == imageId));
        }

        public IResult Update(IFormFile file, PlaceImage placeImage)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfPlaceImageLimit(int placeId)
        {
            var result = _placeImageDal.GetAll(p => p.PlaceId == placeId).Count;
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }


        private IDataResult<List<PlaceImage>> GetDefaultImage(int placeId)
        {

            List<PlaceImage> placeImage = new List<PlaceImage>();
            placeImage.Add(new PlaceImage { PlaceId = placeId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<PlaceImage>>(placeImage);
        }

        private bool CheckPlaceImage(int placeId)
        {
            return _placeImageDal.GetAll(p => p.PlaceId == placeId).Count > 0;

        }
    }
}
