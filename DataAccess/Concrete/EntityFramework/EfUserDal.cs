using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RestLockContext>, IUserDal
    {
        public List<UserType> GetClaims(User user)
        {
            using (var context = new RestLockContext())
            {
                var result = from userType in context.UserTypes
                             join userOperationClaim in context.UserOperationClaims
                                 on userType.UserTypeId equals userOperationClaim.UserTypeId
                             where userOperationClaim.UserId == user.UserId
                             select new UserType { UserTypeId = userType.UserTypeId, UserTypeName = userType.UserTypeName };
                return result.ToList();

            }
        }
    }
}
