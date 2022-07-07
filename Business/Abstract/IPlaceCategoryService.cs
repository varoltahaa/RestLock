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
        List<PlaceCategory> GetAll();
        PlaceCategory Get(int id);
        void Add(PlaceCategory placeCategory);
        void Update(PlaceCategory placeCategory);
        void Delete(PlaceCategory placeCategory);
    }
}
