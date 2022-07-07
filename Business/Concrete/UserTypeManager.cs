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
    public class UserTypeManager : IUserTypeService
    {
        public IResult Add(UserType userType)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserType userType)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserType userType)
        {
            throw new NotImplementedException();
        }
    }
}
