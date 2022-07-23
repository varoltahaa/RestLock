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
    public class MenuCategoryManager : IMenuCategoryService
    {
        IMenuCategoryDal _menuCategoryDal;

        public MenuCategoryManager(IMenuCategoryDal menuCategoryDal)
        {
            _menuCategoryDal = menuCategoryDal;
        }

        public IResult Add(MenuCategory menuCategory)
        {
            _menuCategoryDal.Add(menuCategory);
            return new SuccessResult();
        }

        public IResult Delete(MenuCategory menuCategory)
        {
            _menuCategoryDal.Delete(menuCategory);
            return new SuccessResult();
        }

        public IDataResult<MenuCategory> Get(int id)
        {
            return new SuccessDataResult<MenuCategory>(_menuCategoryDal.Get(m => m.MenuCategoryId == id));
        }

        public IDataResult<List<MenuCategory>> GetAll()
        {
            return new SuccessDataResult<List<MenuCategory>>(_menuCategoryDal.GetAll());
        }

        public IResult Update(MenuCategory menuCategory)
        {
            _menuCategoryDal.Update(menuCategory);
            return new SuccessResult();
        }
    }
}
