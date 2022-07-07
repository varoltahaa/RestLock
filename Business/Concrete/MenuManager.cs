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
    public class MenuManager : IMenuService
    {
        public IResult Add(Menu menu)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Menu menu)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Menu>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Menu>> GetAllByCategoryId(int menuCategoryId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
