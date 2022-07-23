using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlaceImageService
    {

        IResult Add(IFormFile file, PlaceImage placeImage);
        IResult Delete(PlaceImage placeImage);
        IResult Update(IFormFile file, PlaceImage placeImage);

        IDataResult<List<PlaceImage>> GetAll();
        IDataResult<List<PlaceImage>> GetByPlaceId(int placeId);
        IDataResult<PlaceImage> GetByImageId(int imageId);
    }
}
