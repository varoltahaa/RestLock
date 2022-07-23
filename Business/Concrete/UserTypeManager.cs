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
    public class UserTypeManager : IUserTypeService
    {
        IUserTypeDal _userTypeDal;
        public UserTypeManager(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;
        }

        public IResult Add(UserType userType)
        {
            _userTypeDal.Add(userType);
            return new SuccessResult();
        }

        public IResult Delete(UserType userType)
        {
            _userTypeDal.Delete(userType);
            return new SuccessResult();
        }

        public IDataResult<List<UserType>> GetAll()
        {
            return new SuccessDataResult<List<UserType>>(_userTypeDal.GetAll());
        }

        public IResult Update(UserType userType)
        {
            _userTypeDal.Update(userType);
            return new SuccessResult();
        }
    }
}
