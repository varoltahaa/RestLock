using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlaceService
    {
        IDataResult<List<PlaceDetailDto>> GetPlaceDetails();
        IDataResult<List<Place>> GetAll();
        IDataResult<List<Place>> GetAllByCategoryId(int categoryId);
        IResult Add(Place place);
        IResult Update(Place place);
        IResult Delete(Place place);



    }
}
