using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Place place)
        {
            throw new NotImplementedException();
        }

        public void Delete(Place place)
        {
            throw new NotImplementedException();
        }

        public List<Place> GetAll()
        {
            return _placeDal.GetAll();
        }

        public List<Place> GetAllByCategoryId(int categoryId)
        {
            return _placeDal.GetAll(p => p.PlaceCategoryId == categoryId);

        }

        public void Update(Place place)
        {
            throw new NotImplementedException();
        }
    }
}
