using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryPlaceDal : IPlaceDal
    {
        List<Place> _places;
        public InMemoryPlaceDal()
        {
            _places = new List<Place>
            {
                new Place{PlaceId=1,MenuId=1,PlaceCategoryId=1,PlaceName="Cafe",PlaceAddress="Elazığ",PlacePhoneNumber="05536729837"
                ,OpenTime=System.TimeSpan.Zero,CloseTime=System.TimeSpan.Zero,Description="Güzel Cafe" },
                 new Place{PlaceId=2,MenuId=3,PlaceCategoryId=2,PlaceName="Lokanta",PlaceAddress="Edirne",PlacePhoneNumber="05536729837"
                ,OpenTime=System.TimeSpan.Zero,CloseTime=System.TimeSpan.Zero,Description="Güzel Lokanta" }
            };
        }
        public void Add(Place place)
        {
            _places.Add(place);
        }

        public void Delete(Place place)
        {
            Place placeToDelete = _places.SingleOrDefault(x => x.PlaceId == place.PlaceId);
            _places.Remove(placeToDelete);
        }

        public Place Get(Expression<Func<Place, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Place> GetAll()
        {
            return _places;
        }

        public List<Place> GetAll(Expression<Func<Place, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Place> GetAllByCategory(int categoryId)
        {
            return _places.Where(p => p.PlaceCategoryId == categoryId).ToList();
        }

        public void Update(Place place)
        {
            Place placeToUpdate = _places.SingleOrDefault(x => x.PlaceId == place.PlaceId);
            placeToUpdate.PlaceName = place.PlaceName;
            placeToUpdate.PlacePhoneNumber = place.PlacePhoneNumber;
            placeToUpdate.PlaceAddress = place.PlaceAddress;
            placeToUpdate.OpenTime = place.OpenTime;
            placeToUpdate.CloseTime = place.CloseTime;
            placeToUpdate.Description = place.Description;
        }
    }
}
