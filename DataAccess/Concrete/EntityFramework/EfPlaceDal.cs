using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlaceDal : EfEntityRepositoryBase<Place, RestLockContext>, IPlaceDal
    {
        public List<PlaceDetailDto> GetPlaceDetail()
        {
            using (RestLockContext context = new RestLockContext())
            {
                var result = from p in context.Places
                             join m in context.Menus
                             on p.PlaceId equals m.PlaceId
                             join pr in context.Products
                             on m.MenuId equals pr.MenuId
                             join mm in context.MenuCategories
                             on m.MenuCategoryId equals mm.MenuCategoryId
                             select new PlaceDetailDto {PlaceName = p.PlaceName, ProductName = pr.ProductName, UnitPrice = pr.UnitPrice, MenuCategoryName = mm.Name };
                return result.ToList();

            }
        }
    }
}
