using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuService
    {
        List<Menu> GetAll();
        List<Menu> GetAllByCategoryId(int categoryId);
        void Add(Menu menu);
        void Update(Menu menu);
        void Delete(Menu menu);
    }
}
