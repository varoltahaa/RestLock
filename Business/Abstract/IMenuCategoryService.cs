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
        List<MenuCategory> GetAll();
        MenuCategory Get(int id);
        void Add(MenuCategory menuCategory);
        void Update(MenuCategory menuCategory);
        void Delete(MenuCategory menuCategory);
    }
}
