﻿using Core.Utilities.Results;
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
        IDataResult<List<Menu>> GetAll();
        IDataResult<Menu> GetByPlaceId(int placeId);
        IDataResult<List<Menu>> GetAllByCategoryId(int menuCategoryId);
        IResult Add(Menu menu);
        IResult Update(Menu menu);
        IResult Delete(Menu menu);
    }
}
