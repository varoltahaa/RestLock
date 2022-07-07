using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuCategoryService
    {
        IDataResult<List<MenuCategory>> GetAll();
        IDataResult<MenuCategory> Get(int id);
        IResult Add(MenuCategory menuCategory);
        IResult Update(MenuCategory menuCategory);
        IResult Delete(MenuCategory menuCategory);
    }
}
