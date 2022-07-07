using Business.Abstract;
using Core.Utilities.Results;
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
        public IResult Add(MenuCategory menuCategory)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MenuCategory menuCategory)
        {
            throw new NotImplementedException();
        }

        public IDataResult<MenuCategory> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MenuCategory>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(MenuCategory menuCategory)
        {
            throw new NotImplementedException();
        }
    }
}
