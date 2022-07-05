using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlaceService
    {
        List<Place> GetAll();
        List<Place> GetAllByCategoryId(int categoryId);
        void Add(Place place);
        void Update(Place place);
        void Delete(Place place);


    }
}
