using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlaceCategoryService
    {
        IDataResult<List<PlaceCategory>> GetAll();
        IDataResult<PlaceCategory> Get(int id);
        IResult Add(PlaceCategory placeCategory);
        IResult Update(PlaceCategory placeCategory);
        IResult Delete(PlaceCategory placeCategory);
    }
}
