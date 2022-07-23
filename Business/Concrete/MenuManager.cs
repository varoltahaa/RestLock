using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MenuManager : IMenuService
    {

        IMenuDal _menüDal;

        public MenuManager(IMenuDal menüDal)
        {
            _menüDal = menüDal;
        }

        public IResult Add(Menu menu)
        {
             _menüDal.Add(menu);
            return new SuccessResult();
        }

        public IResult Delete(Menu menu)
        {
            _menüDal.Delete(menu);
            return new SuccessResult();
        }

        public IDataResult<List<Menu>> GetAll()
        {
           return new SuccessDataResult<List<Menu>>(_menüDal.GetAll());
        }

        public IDataResult<List<Menu>> GetAllByCategoryId(int menuCategoryId)
        {
            return new SuccessDataResult<List<Menu>>(_menüDal.GetAll());
        }

        public IDataResult<Menu> GetByPlaceId(int placeId)
        {
            return new SuccessDataResult<Menu>(_menüDal.Get(m => m.PlaceId == placeId));
        }

        public IResult Update(Menu menu)
        {
            _menüDal.Update(menu);
            return new SuccessResult();
        }
    }
}
